using Desafio02MiniERP.Databases;
using Desafio02MiniERP.Helpers;
using Desafio02MiniERP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Desafio02MiniERP
{
    public partial class FrmCadastrarFornecedor : Form
    {
        public FrmCadastrarFornecedor()
        {
            InitializeComponent();
            CarregarDataGridView();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.RazaoSocial = txtRazaoSocial.Text;
            dgvFornecedor.DataSource = fornecedor.ConsultarPorRazaoSocial();
            txtRazaoSocial.Text = dgvFornecedor.CurrentRow.Cells["colRazaoSocial"].Value.ToString();
            txtNomeFantasia.Text = dgvFornecedor.CurrentRow.Cells["colNomeFantasia"].Value.ToString();
            mtxCnpj.Text = dgvFornecedor.CurrentRow.Cells["colCnpj"].Value.ToString();
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            CarregarDataGridView();
            CarregarEstadoPadraoBotoes();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor(txtRazaoSocial.Text, txtNomeFantasia.Text, mtxCnpj.Text);

            if (fornecedor.ValidarCamposFornecedor(fornecedor))
            {
                if (fornecedor.GravarFornecedor())
                {
                    MessageBox.Show("Fornecedor salvo com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarDataGridView();
                    btnNovo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                    btnSalvar.Enabled = false;
                    int ultimaLinha = dgvFornecedor.Rows.GetLastRow(0);
                    dgvFornecedor.CurrentCell = dgvFornecedor[0, ultimaLinha];
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar fornecedor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos e válidos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.Id = Convert.ToInt32(dgvFornecedor.CurrentRow.Cells["colId"].Value);
            fornecedor.NomeFantasia = txtNomeFantasia.Text;
            fornecedor.RazaoSocial = txtRazaoSocial.Text;
            fornecedor.Cnpj = mtxCnpj.Text;


            if (fornecedor.ValidarCamposFornecedor(fornecedor))
            {
                if (fornecedor.AtualizarFornecedor())
                {
                    MessageBox.Show("Fornecedor alterado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    CarregarDataGridView();
                    CarregarEstadoPadraoBotoes();
                }
                else
                {
                    MessageBox.Show("Erro ao editar fornecedor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.RazaoSocial = txtRazaoSocial.Text;

            fornecedor = fornecedor.ConsultarFornecedor(fornecedor.RazaoSocial);

            if (fornecedor == null)
            {
                MessageBox.Show("Fornecedor não encontrato!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (fornecedor.ExcluirFornecedor())
            {
                MessageBox.Show("Fornecedor excluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                CarregarDataGridView();
                CarregarEstadoPadraoBotoes();
            }
            else
            {
                MessageBox.Show("Erro ao excluir fornecedor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarEstadoPadraoBotoes()
        {
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void CarregarDataGridView()
        {
            Banco bd = new Banco();

            string sql = "SELECT * FROM fornecedores;";

            DataTable dt = new DataTable();

            dt = bd.ExecutarConsultaGenerica(sql);

            dgvFornecedor.DataSource = dt;
        }

        private void LimparCampos()
        {
            txtNomeFantasia.Clear();
            txtRazaoSocial.Clear();
            mtxCnpj.Clear();
        }
    }
}
