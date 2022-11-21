namespace Desafio02MiniERP
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
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
    }
}