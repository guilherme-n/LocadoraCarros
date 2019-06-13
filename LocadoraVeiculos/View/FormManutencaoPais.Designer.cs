namespace View
{
    partial class FormManutencaoPais : FormPadrao
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
            this.GroupDados = new System.Windows.Forms.GroupBox();
            this.TxtQtdHabitantes = new System.Windows.Forms.TextBox();
            this.TxtAnoFundacao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPib = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtIdiomaPrincipal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.GroupDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupDados
            // 
            this.GroupDados.Controls.Add(this.TxtQtdHabitantes);
            this.GroupDados.Controls.Add(this.TxtAnoFundacao);
            this.GroupDados.Controls.Add(this.label6);
            this.GroupDados.Controls.Add(this.TxtPib);
            this.GroupDados.Controls.Add(this.label4);
            this.GroupDados.Controls.Add(this.label3);
            this.GroupDados.Controls.Add(this.TxtIdiomaPrincipal);
            this.GroupDados.Controls.Add(this.label2);
            this.GroupDados.Controls.Add(this.TxtNome);
            this.GroupDados.Controls.Add(this.label1);
            this.GroupDados.Location = new System.Drawing.Point(12, 12);
            this.GroupDados.Name = "GroupDados";
            this.GroupDados.Size = new System.Drawing.Size(579, 129);
            this.GroupDados.TabIndex = 0;
            this.GroupDados.TabStop = false;
            // 
            // TxtQtdHabitantes
            // 
            this.TxtQtdHabitantes.Location = new System.Drawing.Point(143, 96);
            this.TxtQtdHabitantes.MaxLength = 10;
            this.TxtQtdHabitantes.Name = "TxtQtdHabitantes";
            this.TxtQtdHabitantes.Size = new System.Drawing.Size(100, 20);
            this.TxtQtdHabitantes.TabIndex = 9;
            this.TxtQtdHabitantes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQtdHabitantes_KeyPress);
            // 
            // TxtAnoFundacao
            // 
            this.TxtAnoFundacao.Location = new System.Drawing.Point(468, 36);
            this.TxtAnoFundacao.MaxLength = 4;
            this.TxtAnoFundacao.Name = "TxtAnoFundacao";
            this.TxtAnoFundacao.Size = new System.Drawing.Size(105, 20);
            this.TxtAnoFundacao.TabIndex = 5;
            this.TxtAnoFundacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAnoFundacao_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Qtd. de habitantes";
            // 
            // TxtPib
            // 
            this.TxtPib.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.TxtPib.Location = new System.Drawing.Point(10, 96);
            this.TxtPib.Mask = "$000000000";
            this.TxtPib.Name = "TxtPib";
            this.TxtPib.Size = new System.Drawing.Size(124, 20);
            this.TxtPib.TabIndex = 7;
            this.TxtPib.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "PIB (em Dolar)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ano fundacao";
            // 
            // TxtIdiomaPrincipal
            // 
            this.TxtIdiomaPrincipal.Location = new System.Drawing.Point(239, 36);
            this.TxtIdiomaPrincipal.MaxLength = 50;
            this.TxtIdiomaPrincipal.Name = "TxtIdiomaPrincipal";
            this.TxtIdiomaPrincipal.Size = new System.Drawing.Size(223, 20);
            this.TxtIdiomaPrincipal.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Idioma principal";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(10, 36);
            this.TxtNome.MaxLength = 50;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(223, 20);
            this.TxtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(435, 183);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 1;
            this.BtnCadastrar.Text = "&Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(516, 183);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 23);
            this.BtnFechar.TabIndex = 2;
            this.BtnFechar.Text = "&Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // FormManutencaoPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 218);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.GroupDados);
            this.Name = "FormManutencaoPais";
            this.Text = "Cadastro de pais";
            this.Load += new System.EventHandler(this.FormManutencaoPais_Load);
            this.GroupDados.ResumeLayout(false);
            this.GroupDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupDados;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.TextBox TxtIdiomaPrincipal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TxtPib;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtQtdHabitantes;
        private System.Windows.Forms.TextBox TxtAnoFundacao;
    }
}