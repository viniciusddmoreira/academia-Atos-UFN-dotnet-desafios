using Desafio02MiniERP.Databases;
using Desafio02MiniERP.Helpers;
using Desafio02MiniERP.Models;
using System.Data;

namespace Desafio02MiniERP
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void sobreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmSobre frmSobre = new FrmSobre();
            frmSobre.Show();
        }

        private void tsmiCadastrarCliente_Click(object sender, EventArgs e)
        {
            FrmCadastrarCliente formCadastrarCliente = new FrmCadastrarCliente();
            formCadastrarCliente.Show();
        }

        private void tsmiCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            FrmCadastrarFornecedor frmCadastrarFornecedor = new FrmCadastrarFornecedor();
            frmCadastrarFornecedor.Show();
        }

        private void tsmiCadastrarProduto_Click(object sender, EventArgs e)
        {
            FrmCadastrarProduto frmCadastrarProduto = new FrmCadastrarProduto();
            frmCadastrarProduto.Show();
        }

        NotaFiscal notaFiscal;
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            if (!rdoIdCliente.Checked && !rdoNomeCliente.Checked)
            {
                MessageBox.Show("Selecione se deseja pesquisar por ID ou Nome!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (rdoIdCliente.Checked)
                {
                    if (Util.NumeroInteiroValido(txtPesquisar.Text))
                    {
                        cliente = cliente.ConsultarClienteId(int.Parse(txtPesquisar.Text));
                        if (cliente == null)
                        {
                            MessageBox.Show("Cliente não encontrato!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Informe um número inteiro válido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (rdoNomeCliente.Checked)
                {
                    if(Util.ContemLetras(txtPesquisar.Text) && !Util.ContemNumeros(txtPesquisar.Text))
                    {
                        cliente = cliente.ConsultarCliente(txtPesquisar.Text);
                        if (cliente == null)
                        {
                            MessageBox.Show("Cliente não encontrato!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Informe um nome válido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }            
                }

                MessageBox.Show("Cliente selecionado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                notaFiscal = new NotaFiscal();
                notaFiscal.DataCompra = DateTime.Now;
                notaFiscal.TotalPagar = 0;
                notaFiscal.Cliente = cliente;
                notaFiscal.IdCliente = cliente.Id;
                notaFiscal.GravarNotaFiscal();
                notaFiscal.AtribuirIdNotaFiscal();
                grpSelecionarCliente.Enabled = false;
                grpAdicionarProdutos.Enabled = true;
            }
        }

        List<Produto> listaProdutos = new List<Produto>();
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            if (!rdoIdProduto.Checked && !rdoDescricao.Checked)
            {
                MessageBox.Show("Selecione se deseja pesquisar por ID ou Descrição!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (rdoIdProduto.Checked)
                {
                    if (Util.NumeroInteiroValido(txtAdicionar.Text))
                    {
                        produto = produto.ConsultarProdutoId(int.Parse(txtAdicionar.Text));
                        if (produto == null)
                        {
                            MessageBox.Show("Produto não encontrato!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Informe um número inteiro válido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }              
                }
                else if (rdoDescricao.Checked)
                {
                    if (Util.ContemLetrasOuNumeros(txtAdicionar.Text) )
                    {
                        produto = produto.ConsultarProduto(txtAdicionar.Text);
                        if (produto == null)
                        {
                            MessageBox.Show("Produto não encontrato!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Informe uma descrição de produto válido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }               
                }

                MessageBox.Show("Produto adicionado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                notaFiscal.NotaProdutos.Add(new NotaProduto(notaFiscal.IdNota, produto.Id));
                listaProdutos.Add(produto);
                dgvProdutos.Rows.Clear();
                listaProdutos.ForEach(produto =>
                {
                    var item = new DataGridViewRow();
                    item.Cells.Add(new DataGridViewTextBoxCell { Value = produto.Id.ToString() });
                    item.Cells.Add(new DataGridViewTextBoxCell { Value = produto.CodigoBarra });
                    item.Cells.Add(new DataGridViewTextBoxCell { Value = produto.Descricao });
                    item.Cells.Add(new DataGridViewTextBoxCell { Value = produto.Marca });
                    item.Cells.Add(new DataGridViewTextBoxCell { Value = produto.Valor.ToString("C") });
                    item.Cells.Add(new DataGridViewTextBoxCell { Value = produto.IdFornecedor.ToString() });
                    dgvProdutos.Rows.Add(item);
                });
                var total = listaProdutos.Sum(x => x.Valor);
                notaFiscal.TotalPagar = total;
                lblTotal.Text = total.ToString();
                btnGerarNfe.Enabled = true;
            }
        }

        private void btnGerarNfe_Click(object sender, EventArgs e)
        {
            if (notaFiscal.AtualizarNotaFiscal())
            {
                MessageBox.Show("Nota Fiscal gerada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (var item in notaFiscal.NotaProdutos)
                {
                    item.GravarNotaProduto();
                }
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao gerar nota fiscal!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGerarPdf_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em construção...", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LimparCampos()
        {
            grpSelecionarCliente.Enabled = true;
            grpAdicionarProdutos.Enabled = false;
            rdoIdCliente.Checked = false;
            rdoNomeCliente.Checked = false;
            rdoIdProduto.Checked = false;
            rdoDescricao.Checked = false;
            txtPesquisar.Clear();
            txtAdicionar.Clear();
            listaProdutos.Clear();
            dgvProdutos.Rows.Clear();
            lblTotal.Text = "00,00";
        }
    }
}