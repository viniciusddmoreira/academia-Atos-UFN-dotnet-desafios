namespace Desafio02MiniERP
{
    partial class FrmCadastrarFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.mtxCnpj = new System.Windows.Forms.MaskedTextBox();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRazaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNomeFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Location = new System.Drawing.Point(12, 9);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(72, 15);
            this.lblRazaoSocial.TabIndex = 0;
            this.lblRazaoSocial.Text = "Razão Social";
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Location = new System.Drawing.Point(12, 62);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(86, 15);
            this.lblNomeFantasia.TabIndex = 1;
            this.lblNomeFantasia.Text = "Nome Fantasia";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(12, 121);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(34, 15);
            this.lblCnpj.TabIndex = 2;
            this.lblCnpj.Text = "CNPJ";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(12, 27);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(224, 23);
            this.txtRazaoSocial.TabIndex = 0;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Location = new System.Drawing.Point(12, 80);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(224, 23);
            this.txtNomeFantasia.TabIndex = 2;
            // 
            // mtxCnpj
            // 
            this.mtxCnpj.Location = new System.Drawing.Point(12, 139);
            this.mtxCnpj.Mask = "00,000,000/0000-00";
            this.mtxCnpj.Name = "mtxCnpj";
            this.mtxCnpj.Size = new System.Drawing.Size(120, 23);
            this.mtxCnpj.TabIndex = 3;
            this.mtxCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.AllowUserToAddRows = false;
            this.dgvFornecedor.AllowUserToDeleteRows = false;
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.colRazaoSocial,
            this.ColNomeFantasia,
            this.ColCnpj});
            this.dgvFornecedor.Location = new System.Drawing.Point(12, 229);
            this.dgvFornecedor.MultiSelect = false;
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.ReadOnly = true;
            this.dgvFornecedor.RowHeadersVisible = false;
            this.dgvFornecedor.RowTemplate.Height = 25;
            this.dgvFornecedor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFornecedor.Size = new System.Drawing.Size(578, 219);
            this.dgvFornecedor.TabIndex = 7;
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "id";
            this.ColId.HeaderText = "ID";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Width = 30;
            // 
            // colRazaoSocial
            // 
            this.colRazaoSocial.DataPropertyName = "razao_social";
            this.colRazaoSocial.HeaderText = "Razão Social";
            this.colRazaoSocial.Name = "colRazaoSocial";
            this.colRazaoSocial.ReadOnly = true;
            this.colRazaoSocial.Width = 220;
            // 
            // ColNomeFantasia
            // 
            this.ColNomeFantasia.DataPropertyName = "nome_fantasia";
            this.ColNomeFantasia.HeaderText = "Nome Fantasia";
            this.ColNomeFantasia.Name = "ColNomeFantasia";
            this.ColNomeFantasia.ReadOnly = true;
            this.ColNomeFantasia.Width = 200;
            // 
            // ColCnpj
            // 
            this.ColCnpj.DataPropertyName = "cnpj";
            dataGridViewCellStyle1.NullValue = null;
            this.ColCnpj.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColCnpj.HeaderText = "CNPJ";
            this.ColCnpj.Name = "ColCnpj";
            this.ColCnpj.ReadOnly = true;
            this.ColCnpj.Width = 110;
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(174, 178);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(255, 178);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.Location = new System.Drawing.Point(242, 26);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(79, 25);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar ...";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(93, 178);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Enabled = false;
            this.btnNovo.Location = new System.Drawing.Point(12, 178);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // FrmCadastrarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 460);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvFornecedor);
            this.Controls.Add(this.mtxCnpj);
            this.Controls.Add(this.txtNomeFantasia);
            this.Controls.Add(this.txtRazaoSocial);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.lblNomeFantasia);
            this.Controls.Add(this.lblRazaoSocial);
            this.Name = "FrmCadastrarFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Fornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRazaoSocial;
        private Label lblNomeFantasia;
        private Label lblCnpj;
        private TextBox txtRazaoSocial;
        private TextBox txtNomeFantasia;
        private MaskedTextBox mtxCnpj;
        private DataGridView dgvFornecedor;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnPesquisar;
        private Button btnSalvar;
        private Button btnNovo;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn colRazaoSocial;
        private DataGridViewTextBoxColumn ColNomeFantasia;
        private DataGridViewTextBoxColumn ColCnpj;
    }
}