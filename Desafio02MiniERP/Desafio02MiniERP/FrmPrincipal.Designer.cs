namespace Desafio02MiniERP
{
    partial class FrmPrincipal
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
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAdicionar = new System.Windows.Forms.TextBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.grpSelecionarCliente = new System.Windows.Forms.GroupBox();
            this.rdoNomeCliente = new System.Windows.Forms.RadioButton();
            this.rdoIdCliente = new System.Windows.Forms.RadioButton();
            this.grpAdicionarProdutos = new System.Windows.Forms.GroupBox();
            this.rdoDescricao = new System.Windows.Forms.RadioButton();
            this.rdoIdProduto = new System.Windows.Forms.RadioButton();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGerarNfe = new System.Windows.Forms.Button();
            this.btnGerarPdf = new System.Windows.Forms.Button();
            this.lbl_TotalPagar = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.mnsPrincipal.SuspendLayout();
            this.grpSelecionarCliente.SuspendLayout();
            this.grpAdicionarProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsPrincipal
            // 
            this.mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
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
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click_1);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // txtAdicionar
            // 
            this.txtAdicionar.Location = new System.Drawing.Point(15, 58);
            this.txtAdicionar.Name = "txtAdicionar";
            this.txtAdicionar.Size = new System.Drawing.Size(203, 23);
            this.txtAdicionar.TabIndex = 6;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(6, 59);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(179, 23);
            this.txtPesquisar.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(191, 58);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(84, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar ...";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // grpSelecionarCliente
            // 
            this.grpSelecionarCliente.Controls.Add(this.rdoNomeCliente);
            this.grpSelecionarCliente.Controls.Add(this.rdoIdCliente);
            this.grpSelecionarCliente.Controls.Add(this.btnPesquisar);
            this.grpSelecionarCliente.Controls.Add(this.txtPesquisar);
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
            this.rdoNomeCliente.TabIndex = 1;
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
            this.rdoIdCliente.TabIndex = 0;
            this.rdoIdCliente.TabStop = true;
            this.rdoIdCliente.Text = "ID Cliente";
            this.rdoIdCliente.UseVisualStyleBackColor = true;
            // 
            // grpAdicionarProdutos
            // 
            this.grpAdicionarProdutos.Controls.Add(this.rdoDescricao);
            this.grpAdicionarProdutos.Controls.Add(this.rdoIdProduto);
            this.grpAdicionarProdutos.Controls.Add(this.btnAdicionar);
            this.grpAdicionarProdutos.Controls.Add(this.txtAdicionar);
            this.grpAdicionarProdutos.Enabled = false;
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
            this.rdoDescricao.TabIndex = 5;
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
            this.rdoIdProduto.TabIndex = 4;
            this.rdoIdProduto.TabStop = true;
            this.rdoIdProduto.Text = "ID Produto";
            this.rdoIdProduto.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(224, 59);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colCodigoBarras,
            this.colDescricao,
            this.colMarca,
            this.colValor,
            this.colIdFornecedor});
            this.dgvProdutos.Location = new System.Drawing.Point(12, 191);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.RowTemplate.Height = 25;
            this.dgvProdutos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProdutos.Size = new System.Drawing.Size(762, 183);
            this.dgvProdutos.TabIndex = 10;
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
            this.btnGerarNfe.Enabled = false;
            this.btnGerarNfe.Location = new System.Drawing.Point(12, 386);
            this.btnGerarNfe.Name = "btnGerarNfe";
            this.btnGerarNfe.Size = new System.Drawing.Size(80, 25);
            this.btnGerarNfe.TabIndex = 8;
            this.btnGerarNfe.Text = "Gerar NF-e";
            this.btnGerarNfe.UseVisualStyleBackColor = true;
            this.btnGerarNfe.Click += new System.EventHandler(this.btnGerarNfe_Click);
            // 
            // btnGerarPdf
            // 
            this.btnGerarPdf.Location = new System.Drawing.Point(98, 386);
            this.btnGerarPdf.Name = "btnGerarPdf";
            this.btnGerarPdf.Size = new System.Drawing.Size(75, 25);
            this.btnGerarPdf.TabIndex = 9;
            this.btnGerarPdf.Text = "Gerar PDF";
            this.btnGerarPdf.UseVisualStyleBackColor = true;
            this.btnGerarPdf.Click += new System.EventHandler(this.btnGerarPdf_Click);
            // 
            // lbl_TotalPagar
            // 
            this.lbl_TotalPagar.AutoSize = true;
            this.lbl_TotalPagar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TotalPagar.Location = new System.Drawing.Point(530, 386);
            this.lbl_TotalPagar.Name = "lbl_TotalPagar";
            this.lbl_TotalPagar.Size = new System.Drawing.Size(167, 30);
            this.lbl_TotalPagar.TabIndex = 13;
            this.lbl_TotalPagar.Text = "Total a Pagar: R$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(689, 386);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(62, 30);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "00,00";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 420);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lbl_TotalPagar);
            this.Controls.Add(this.btnGerarPdf);
            this.Controls.Add(this.btnGerarNfe);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.grpAdicionarProdutos);
            this.Controls.Add(this.grpSelecionarCliente);
            this.Controls.Add(this.mnsPrincipal);
            this.MainMenuStrip = this.mnsPrincipal;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Vendas Mini ERP";
            this.mnsPrincipal.ResumeLayout(false);
            this.mnsPrincipal.PerformLayout();
            this.grpSelecionarCliente.ResumeLayout(false);
            this.grpSelecionarCliente.PerformLayout();
            this.grpAdicionarProdutos.ResumeLayout(false);
            this.grpAdicionarProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mnsPrincipal;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem tsmiCadastrarProduto;
        private ToolStripMenuItem tsmiCadastrarFornecedor;
        private ToolStripMenuItem tsmiCadastrarCliente;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private TextBox txtAdicionar;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private GroupBox grpSelecionarCliente;
        private GroupBox grpAdicionarProdutos;
        private Button btnAdicionar;
        private DataGridView dgvProdutos;
        private Button btnGerarNfe;
        private Button btnGerarPdf;
        private Label lbl_TotalPagar;
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
        private Label lblTotal;
    }
}