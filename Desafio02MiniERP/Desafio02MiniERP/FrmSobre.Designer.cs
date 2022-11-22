namespace Desafio02MiniERP
{
    partial class FrmSobre
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
            this.lblSobre = new System.Windows.Forms.Label();
            this.BtnOkSobre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSobre
            // 
            this.lblSobre.AutoSize = true;
            this.lblSobre.Location = new System.Drawing.Point(79, 26);
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(249, 30);
            this.lblSobre.TabIndex = 0;
            this.lblSobre.Text = "Desafio desenvolvido na academia .NET entre \r\na empresa Atos e a Universidade Fra" +
    "nciscana.";
            // 
            // BtnOkSobre
            // 
            this.BtnOkSobre.Location = new System.Drawing.Point(155, 81);
            this.BtnOkSobre.Name = "BtnOkSobre";
            this.BtnOkSobre.Size = new System.Drawing.Size(75, 23);
            this.BtnOkSobre.TabIndex = 1;
            this.BtnOkSobre.Text = "OK";
            this.BtnOkSobre.UseVisualStyleBackColor = true;
            this.BtnOkSobre.Click += new System.EventHandler(this.BtnOkSobre_Click);
            // 
            // FrmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 134);
            this.Controls.Add(this.BtnOkSobre);
            this.Controls.Add(this.lblSobre);
            this.Name = "FrmSobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSobre;
        private Button BtnOkSobre;
    }
}