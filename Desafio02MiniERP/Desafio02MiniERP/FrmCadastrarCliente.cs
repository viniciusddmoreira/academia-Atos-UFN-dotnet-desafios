using Desafio02MiniERP.Databases;
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

namespace Desafio02MiniERP
{
    public partial class FrmCadastrarCliente : Form
    {
        public FrmCadastrarCliente()
        {
            InitializeComponent();
            CarregarDataGridView();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            dgvCliente.DataSource = cliente.ConsultarPorNome();
            txtNome.Text = dgvCliente.CurrentRow.Cells["colNome"].Value.ToString();
            txtEndereco.Text = dgvCliente.CurrentRow.Cells["colEndereco"].Value.ToString();
            mtxCpf.Text = dgvCliente.CurrentRow.Cells["colCpf"].Value.ToString();
            mtxTelefone.Text = dgvCliente.CurrentRow.Cells["colTelefone"].Value.ToString();
            txtEmail.Text = dgvCliente.CurrentRow.Cells["colEmail"].Value.ToString();
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
            Cliente cliente = new Cliente(txtNome.Text, txtEndereco.Text, mtxTelefone.Text, txtEmail.Text, mtxCpf.Text);

            if (cliente.ValidarCamposCliente(cliente))
            {
                if (cliente.GravarCliente())
                {
                    MessageBox.Show("Cliente salvo com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarDataGridView();
                    btnNovo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                    btnSalvar.Enabled = false;
                    int ultimaLinha = dgvCliente.Rows.GetLastRow(0);
                    dgvCliente.CurrentCell = dgvCliente[0, ultimaLinha];
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Os campos obrigatórios devem ser preenchidos e válidos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Id = Convert.ToInt32(dgvCliente.CurrentRow.Cells["colId"].Value);
            cliente.Nome = txtNome.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Cpf = mtxCpf.Text;
            cliente.Telefone = mtxTelefone.Text;
            cliente.Email = txtEmail.Text;

            if (cliente.ValidarCamposCliente(cliente))
            {
                if (cliente.AtualizarCliente())
                {
                    MessageBox.Show("Cliente alterado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    CarregarDataGridView();
                    CarregarEstadoPadraoBotoes();
                }
                else
                {
                    MessageBox.Show("Erro ao editar cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Os campos obrigatórios devem ser preenchidos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;

            cliente = cliente.ConsultarCliente(cliente.Nome);

            if (cliente == null)
            {
                MessageBox.Show("Cliente não encontrato!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cliente.ExcluirCliente())
            {
                MessageBox.Show("Cliente excluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                CarregarDataGridView();
                CarregarEstadoPadraoBotoes();
            }
            else
            {
                MessageBox.Show("Erro ao excluir cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarDataGridView()
        {
            Banco bd = new Banco();

            string sql = "SELECT * FROM clientes;";

            DataTable dt = new DataTable();

            dt = bd.ExecutarConsultaGenerica(sql);

            dgvCliente.DataSource = dt;
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtEndereco.Clear();
            mtxCpf.Clear();
            mtxTelefone.Clear();
            txtEmail.Clear();
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
