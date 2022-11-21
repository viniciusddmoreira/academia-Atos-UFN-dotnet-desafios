namespace Desafio02MiniERP
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnsPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastrarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastrarFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastrarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.grpSelecionarCliente = new System.Windows.Forms.GroupBox();
            this.rdoNomeCliente = new System.Windows.Forms.RadioButton();
            this.rdoIdCliente = new System.Windows.Forms.RadioButton();
            this.grpAdicionarProdutos = new System.Windows.Forms.GroupBox();
            this.rdoDescricao = new System.Windows.Forms.RadioButton();
            this.rdoIdProduto = new System.Windows.Forms.RadioButton();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGerarNfe = new System.Windows.Forms.Button();
            this.btnGerarPdf = new System.Windows.Forms.Button();
            this.lbl_ValorVenda = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.mnsPrincipal.SuspendLayout();
            this.grpSelecionarCliente.SuspendLayout();
            this.grpAdicionarProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsPrincipal
            // 
            this.mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.mnsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsPrincipal.Name = "mnsPrincipal";
            this.mnsPrincipal.Size = new System.Drawing.Size(785, 24);
            this.mnsPrincipal.TabIndex = 0;
            this.mnsPrincipal.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCadastrarProduto,
            this.tsmiCadastrarFornecedor,
            this.tsmiCadastrarCliente});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastrar/Pesquisar";
            // 
            // tsmiCadastrarProduto
            // 
            this.tsmiCadastrarProduto.Name = "tsmiCadastrarProduto";
            this.tsmiCadastrarProduto.Size = new System.Drawing.Size(134, 22);
            this.tsmiCadastrarProduto.Text = "Produto";
            this.tsmiCadastrarProduto.Click += new System.EventHandler(this.tsmiCadastrarProduto_Click);
            // 
            // tsmiCadastrarFornecedor
            // 
            this.tsmiCadastrarFornecedor.Name = "tsmiCadastrarFornecedor";
            this.tsmiCadastrarFornecedor.Size = new System.Drawing.Size(134, 22);
            this.tsmiCadastrarFornecedor.Text = "Fornecedor";
            this.tsmiCadastrarFornecedor.Click += new System.EventHandler(this.tsmiCadastrarFornecedor_Click);
            // 
            // tsmiCadastrarCliente
            // 
            this.tsmiCadastrarCliente.Name = "tsmiCadastrarCliente";
            this.tsmiCadastrarCliente.Size = new System.Drawing.Size(134, 22);
            this.tsmiCadastrarCliente.Text = "Cliente";
            this.tsmiCadastrarCliente.Click += new System.EventHandler(this.tsmiCadastrarCliente_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarProdutosToolStripMenuItem});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // consultarProdutosToolStripMenuItem
            // 
            this.consultarProdutosToolStripMenuItem.Name = "consultarProdutosToolStripMenuItem";
            this.consultarProdutosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.consultarProdutosToolStripMenuItem.Text = "Consultar Nota Fiscal";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 23);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 23);
            this.textBox1.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(191, 58);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(84, 23);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "Pesquisar ...";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // grpSelecionarCliente
            // 
            this.grpSelecionarCliente.Controls.Add(this.rdoNomeCliente);
            this.grpSelecionarCliente.Controls.Add(this.rdoIdCliente);
            this.grpSelecionarCliente.Controls.Add(this.btnPesquisar);
            this.grpSelecionarCliente.Controls.Add(this.textBox1);
            this.grpSelecionarCliente.Location = new System.Drawing.Point(12, 39);
            this.grpSelecionarCliente.Name = "grpSelecionarCliente";
            this.grpSelecionarCliente.Size = new System.Drawing.Size(330, 115);
            this.grpSelecionarCliente.TabIndex = 8;
            this.grpSelecionarCliente.TabStop = false;
            this.grpSelecionarCliente.Text = "Selecionar Cliente";
            // 
            // rdoNomeCliente
            // 
            this.rdoNomeCliente.AutoSize = true;
            this.rdoNomeCliente.Location = new System.Drawing.Point(106, 27);
            this.rdoNomeCliente.Name = "rdoNomeCliente";
            this.rdoNomeCliente.Size = new System.Drawing.Size(58, 19);
            this.rdoNomeCliente.TabIndex = 9;
            this.rdoNomeCliente.TabStop = true;
            this.rdoNomeCliente.Text = "Nome";
            this.rdoNomeCliente.UseVisualStyleBackColor = true;
            // 
            // rdoIdCliente
            // 
            this.rdoIdCliente.AutoSize = true;
            this.rdoIdCliente.Location = new System.Drawing.Point(6, 27);
            this.rdoIdCliente.Name = "rdoIdCliente";
            this.rdoIdCliente.Size = new System.Drawing.Size(76, 19);
            this.rdoIdCliente.TabIndex = 8;
            this.rdoIdCliente.TabStop = true;
            this.rdoIdCliente.Text = "ID Cliente";
            this.rdoIdCliente.UseVisualStyleBackColor = true;
            // 
            // grpAdicionarProdutos
            // 
            this.grpAdicionarProdutos.Controls.Add(this.rdoDescricao);
            this.grpAdicionarProdutos.Controls.Add(this.rdoIdProduto);
            this.grpAdicionarProdutos.Controls.Add(this.btnAdicionar);
            this.grpAdicionarProdutos.Controls.Add(this.textBox2);
            this.grpAdicionarProdutos.Location = new System.Drawing.Point(348, 39);
            this.grpAdicionarProdutos.Name = "grpAdicionarProdutos";
            this.grpAdicionarProdutos.Size = new System.Drawing.Size(330, 115);
            this.grpAdicionarProdutos.TabIndex = 9;
            this.grpAdicionarProdutos.TabStop = false;
            this.grpAdicionarProdutos.Text = "Adicionar Produtos";
            // 
            // rdoDescricao
            // 
            this.rdoDescricao.AutoSize = true;
            this.rdoDescricao.Location = new System.Drawing.Point(115, 27);
            this.rdoDescricao.Name = "rdoDescricao";
            this.rdoDescricao.Size = new System.Drawing.Size(76, 19);
            this.rdoDescricao.TabIndex = 11;
            this.rdoDescricao.TabStop = true;
            this.rdoDescricao.Text = "Descrição";
            this.rdoDescricao.UseVisualStyleBackColor = true;
            // 
            // rdoIdProduto
            // 
            this.rdoIdProduto.AutoSize = true;
            this.rdoIdProduto.Location = new System.Drawing.Point(15, 27);
            this.rdoIdProduto.Name = "rdoIdProduto";
            this.rdoIdProduto.Size = new System.Drawing.Size(82, 19);
            this.rdoIdProduto.TabIndex = 10;
            this.rdoIdProduto.TabStop = true;
            this.rdoIdProduto.Text = "ID Produto";
            this.rdoIdProduto.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(224, 59);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colCodigoBarras,
            this.colDescricao,
            this.colMarca,
            this.colValor,
            this.colIdFornecedor});
            this.dataGridView1.Location = new System.Drawing.Point(12, 191);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(762, 183);
            this.dataGridView1.TabIndex = 10;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "id";
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 30;
            // 
            // colCodigoBarras
            // 
            this.colCodigoBarras.DataPropertyName = "codigo_barra";
            this.colCodigoBarras.HeaderText = "Cód. de Barras";
            this.colCodigoBarras.Name = "colCodigoBarras";
            this.colCodigoBarras.ReadOnly = true;
            this.colCodigoBarras.Width = 130;
            // 
            // colDescricao
            // 
            this.colDescricao.DataPropertyName = "descricao";
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            this.colDescricao.Width = 210;
            // 
            // colMarca
            // 
            this.colMarca.DataPropertyName = "marca";
            this.colMarca.HeaderText = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.ReadOnly = true;
            this.colMarca.Width = 180;
            // 
            // colValor
            // 
            this.colValor.DataPropertyName = "valor";
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            // 
            // colIdFornecedor
            // 
            this.colIdFornecedor.DataPropertyName = "id_fornecedor";
            this.colIdFornecedor.HeaderText = "ID Fornecedor";
            this.colIdFornecedor.Name = "colIdFornecedor";
            this.colIdFornecedor.ReadOnly = true;
            this.colIdFornecedor.Width = 104;
            // 
            // btnGerarNfe
            // 
            this.btnGerarNfe.AutoSize = true;
            this.btnGerarNfe.Location = new System.Drawing.Point(98, 386);
            this.btnGerarNfe.Name = "btnGerarNfe";
            this.btnGerarNfe.Size = new System.Drawing.Size(80, 25);
            this.btnGerarNfe.TabIndex = 11;
            this.btnGerarNfe.Text = "Gerar NF-e";
            this.btnGerarNfe.UseVisualStyleBackColor = true;
            // 
            // btnGerarPdf
            // 
            this.btnGerarPdf.Location = new System.Drawing.Point(184, 386);
            this.btnGerarPdf.Name = "btnGerarPdf";
            this.btnGerarPdf.Size = new System.Drawing.Size(75, 25);
            this.btnGerarPdf.TabIndex = 12;
            this.btnGerarPdf.Text = "Gerar PDF";
            this.btnGerarPdf.UseVisualStyleBackColor = true;
            // 
            // lbl_ValorVenda
            // 
            this.lbl_ValorVenda.AutoSize = true;
            this.lbl_ValorVenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ValorVenda.Location = new System.Drawing.Point(607, 390);
            this.lbl_ValorVenda.Name = "lbl_ValorVenda";
            this.lbl_ValorVenda.Size = new System.Drawing.Size(166, 21);
            this.lbl_ValorVenda.TabIndex = 13;
            this.lbl_ValorVenda.Text = "Total a Pagar: R$ 00,00";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 386);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(80, 25);
            this.btnNovo.TabIndex = 14;
            this.btnNovo.Text = "Nova Venda";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 420);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lbl_ValorVenda);
            this.Controls.Add(this.btnGerarPdf);
            this.Controls.Add(this.btnGerarNfe);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpAdicionarProdutos);
            this.Controls.Add(this.grpSelecionarCliente);
            this.Controls.Add(this.mnsPrincipal);
            this.MainMenuStrip = this.mnsPrincipal;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Vendas";
            this.mnsPrincipal.ResumeLayout(false);
            this.mnsPrincipal.PerformLayout();
            this.grpSelecionarCliente.ResumeLayout(false);
            this.grpSelecionarCliente.PerformLayout();
            this.grpAdicionarProdutos.ResumeLayout(false);
            this.grpAdicionarProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mnsPrincipal;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem tsmiCadastrarProduto;
        private ToolStripMenuItem tsmiCadastrarFornecedor;
        private ToolStripMenuItem tsmiCadastrarCliente;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem consultarProdutosToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnPesquisar;
        private GroupBox grpSelecionarCliente;
        private GroupBox grpAdicionarProdutos;
        private Button btnAdicionar;
        private DataGridView dataGridView1;
        private Button btnGerarNfe;
        private Button btnGerarPdf;
        private Label lbl_ValorVenda;
        private Button btnNovo;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colCodigoBarras;
        private DataGridViewTextBoxColumn colDescricao;
        private DataGridViewTextBoxColumn colMarca;
        private DataGridViewTextBoxColumn colValor;
        private DataGridViewTextBoxColumn colIdFornecedor;
        private RadioButton rdoNomeCliente;
        private RadioButton rdoIdCliente;
        private RadioButton rdoDescricao;
        private RadioButton rdoIdProduto;
    }
}