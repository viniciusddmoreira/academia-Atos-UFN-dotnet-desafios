using Desafio02MiniERP.Databases;
using Desafio02MiniERP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio02MiniERP
{
    public partial class FrmCadastrarProduto : Form
    {
        public FrmCadastrarProduto()
        {
            InitializeComponent();
            CarregarDataGridView();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Descricao = txtDescricao.Text;
            DataTable dt = new DataTable();
            dt = produto.ConsultarPorDescricao();
            
            if (dt == null)
            {
                MessageBox.Show("Produto não encontrato!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dgvProduto.DataSource = dt;
                txtDescricao.Text = dgvProduto.CurrentRow.Cells["colDescricao"].Value.ToString();
                txtCodigoBarra.Text = dgvProduto.CurrentRow.Cells["colCodigoBarra"].Value.ToString();
                txtMarca.Text = dgvProduto.CurrentRow.Cells["colMarca"].Value.ToString();
                txtIdFornecedor.Text = dgvProduto.CurrentRow.Cells["colIdFornecedor"].Value.ToString();
                txtValor.Text = dgvProduto.CurrentRow.Cells["colValor"].Value.ToString();
                btnNovo.Enabled = true;
                btnEditar.Enabled = true;
                btnSalvar.Enabled = false;
                btnExcluir.Enabled = true;
            }          
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            CarregarDataGridView();
            CarregarEstadoPadraoBotoes();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(txtCodigoBarra.Text, txtMarca.Text, txtDescricao.Text, decimal.Parse(txtValor.Text), int.Parse(txtIdFornecedor.Text));

            if (produto.ValidarCamposProduto())
            {
                if (produto.GravarProduto())
                {
                    MessageBox.Show("Produto salvo com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarDataGridView();
                    btnNovo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                    btnSalvar.Enabled = false;
                    int ultimaLinha = dgvProduto.Rows.GetLastRow(0);
                    dgvProduto.CurrentCell = dgvProduto[0, ultimaLinha];
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Os campos obrigatórios devem ser preenchidos e válidos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Id = Convert.ToInt32(dgvProduto.CurrentRow.Cells["colId"].Value);
            produto.Descricao = txtDescricao.Text;
            produto.CodigoBarra = txtCodigoBarra.Text;
            produto.Marca = txtMarca.Text;
            produto.IdFornecedor = int.Parse(txtIdFornecedor.Text);
            produto.Valor = decimal.Parse(txtValor.Text);

            if (produto.ValidarCamposProduto())
            {
                if (produto.AtualizarProduto())
                {
                    MessageBox.Show("Produto alterado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    CarregarDataGridView();
                    CarregarEstadoPadraoBotoes();
                }
                else
                {
                    MessageBox.Show("Erro ao editar produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Os campos obrigatórios devem ser preenchidos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Descricao = txtDescricao.Text;

            produto = produto.ConsultarProduto(produto.Descricao);

            if (produto == null)
            {
                MessageBox.Show("Produto não encontrato!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (produto.ExcluirProduto())
            {
                MessageBox.Show("Produto excluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                CarregarDataGridView();
                CarregarEstadoPadraoBotoes();
            }
            else
            {
                MessageBox.Show("Erro ao excluir produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarDataGridView()
        {
            Banco bd = new Banco();

            string sql = "SELECT * FROM produtos;";

            DataTable dt = new DataTable();

            dt = bd.ExecutarConsultaGenerica(sql);

            dgvProduto.DataSource = dt;
        }
        private void LimparCampos()
        {
            txtDescricao.Clear();
            txtCodigoBarra.Clear();
            txtMarca.Clear();
            txtIdFornecedor.Clear();
            txtValor.Clear();
        }

        private void CarregarEstadoPadraoBotoes()
        {
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }
    }
}
