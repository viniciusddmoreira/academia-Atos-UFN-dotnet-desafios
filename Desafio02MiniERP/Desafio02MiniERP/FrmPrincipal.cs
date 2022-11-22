using Desafio02MiniERP.Databases;
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

        //List<Cliente> clientes = new List<Cliente>();
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
                    cliente = cliente.ConsultarClienteId(int.Parse(txtPesquisar.Text));
                    if (cliente == null)
                    {
                        MessageBox.Show("Cliente não encontrato!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (rdoNomeCliente.Checked)
                {
                    cliente = cliente.ConsultarCliente(txtPesquisar.Text);
                    if (cliente == null)
                    {
                        MessageBox.Show("Cliente não encontrato!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                //MessageBox.Show("id da nota: " + notaFiscal.IdNota.ToString());
                //notasFiscais.Add(notaFiscal);
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
                    produto = produto.ConsultarProdutoId(int.Parse(txtAdicionar.Text));
                    if (produto == null)
                    {
                        MessageBox.Show("Produto não encontrato!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (rdoNomeCliente.Checked)
                {
                    produto = produto.ConsultarProduto(txtAdicionar.Text);
                    if (produto == null)
                    {
                        MessageBox.Show("Produto não encontrato!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                MessageBox.Show("Produto adicionado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //NotaFiscal notaFiscal = new NotaFiscal();
                //notaFiscal = notasFiscais[0];
                //notaFiscal.NotaProdutos = new List<NotaProduto>()
                //{
                //    new NotaProduto()
                //    {
                //        IdNotaFiscal = notaFiscal.IdNota, IdProduto = produto.Id
                //    }
                //};
                notaFiscal.NotaProdutos.Add(new NotaProduto(notaFiscal.IdNota, produto.Id));

                //Add(new NotaProduto(notaFiscal.IdNota, produto.Id));
                listaProdutos.Add(produto);
                
                //MessageBox.Show(produto.Descricao);
                // dgvProdutos.DataSource = listaProdutos;
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
                lblTotal.Text = total.ToString("C");

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
                grpSelecionarCliente.Enabled = true;
                grpAdicionarProdutos.Enabled = false;
                listaProdutos.Clear();
                //notaFiscal.NotaProdutos.ForEach(notaProdutos => {
                //    notaProdutos.GravarNotaProduto();
                //    });
            }
            else
            {
                MessageBox.Show("Erro ao gerar nota fiscal!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            grpSelecionarCliente.Enabled = true;
            grpAdicionarProdutos.Enabled = false;
            listaProdutos.Clear();
        }  
    }
}