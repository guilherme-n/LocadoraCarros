namespace View
{
    partial class FormAlteracaoSenha : FormPadrao
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
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtConfirmacaoSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNomeVendedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Location = new System.Drawing.Point(202, 204);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirmar.TabIndex = 3;
            this.BtnConfirmar.Text = "&Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(283, 204);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 23);
            this.BtnFechar.TabIndex = 4;
            this.BtnFechar.Text = "&Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtConfirmacaoSenha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtSenha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtNomeVendedor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TxtConfirmacaoSenha
            // 
            this.TxtConfirmacaoSenha.Location = new System.Drawing.Point(9, 131);
            this.TxtConfirmacaoSenha.MaxLength = 30;
            this.TxtConfirmacaoSenha.Name = "TxtConfirmacaoSenha";
            this.TxtConfirmacaoSenha.PasswordChar = '*';
            this.TxtConfirmacaoSenha.Size = new System.Drawing.Size(326, 20);
            this.TxtConfirmacaoSenha.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Confirmar senha";
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(9, 81);
            this.TxtSenha.MaxLength = 30;
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(326, 20);
            this.TxtSenha.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Senha";
            // 
            // TxtNomeVendedor
            // 
            this.TxtNomeVendedor.Location = new System.Drawing.Point(9, 35);
            this.TxtNomeVendedor.MaxLength = 10;
            this.TxtNomeVendedor.Name = "TxtNomeVendedor";
            this.TxtNomeVendedor.ReadOnly = true;
            this.TxtNomeVendedor.Size = new System.Drawing.Size(326, 20);
            this.TxtNomeVendedor.TabIndex = 11;
            this.TxtNomeVendedor.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vendedor logado";
            // 
            // FormAlteracaoSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 239);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAlteracaoSenha";
            this.Text = "Alteração de senha";
            this.Load += new System.EventHandler(this.FormAlteracaoSenha_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtNomeVendedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtConfirmacaoSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button BtnFechar;
    }
}