namespace LocadoraVeiculos.View
{
    partial class FormManutencaoVeiculo : FormPadrao
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
            this.TxtQtdFabricas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtLucroAnual = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtFaturamento = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DtDataFundacao = new System.Windows.Forms.DateTimePicker();
            this.TxtCidadeFundacao = new System.Windows.Forms.TextBox();
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
            this.GroupDados.Controls.Add(this.TxtQtdFabricas);
            this.GroupDados.Controls.Add(this.label6);
            this.GroupDados.Controls.Add(this.TxtLucroAnual);
            this.GroupDados.Controls.Add(this.label5);
            this.GroupDados.Controls.Add(this.TxtFaturamento);
            this.GroupDados.Controls.Add(this.label4);
            this.GroupDados.Controls.Add(this.label3);
            this.GroupDados.Controls.Add(this.DtDataFundacao);
            this.GroupDados.Controls.Add(this.TxtCidadeFundacao);
            this.GroupDados.Controls.Add(this.label2);
            this.GroupDados.Controls.Add(this.TxtNome);
            this.GroupDados.Controls.Add(this.label1);
            this.GroupDados.Location = new System.Drawing.Point(24, 23);
            this.GroupDados.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.GroupDados.Name = "GroupDados";
            this.GroupDados.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.GroupDados.Size = new System.Drawing.Size(1158, 248);
            this.GroupDados.TabIndex = 0;
            this.GroupDados.TabStop = false;
            // 
            // TxtQtdFabricas
            // 
            this.TxtQtdFabricas.Location = new System.Drawing.Point(514, 185);
            this.TxtQtdFabricas.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtQtdFabricas.MaxLength = 7;
            this.TxtQtdFabricas.Name = "TxtQtdFabricas";
            this.TxtQtdFabricas.Size = new System.Drawing.Size(206, 31);
            this.TxtQtdFabricas.TabIndex = 12;
            this.TxtQtdFabricas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQtdFabricas_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(514, 154);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Qtd de fabricas";
            // 
            // TxtLucroAnual
            // 
            this.TxtLucroAnual.Location = new System.Drawing.Point(280, 185);
            this.TxtLucroAnual.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtLucroAnual.Mask = "000000000";
            this.TxtLucroAnual.Name = "TxtLucroAnual";
            this.TxtLucroAnual.Size = new System.Drawing.Size(218, 31);
            this.TxtLucroAnual.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lucro anual (em Dolar)";
            // 
            // TxtFaturamento
            // 
            this.TxtFaturamento.Location = new System.Drawing.Point(20, 185);
            this.TxtFaturamento.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtFaturamento.Mask = "000000000";
            this.TxtFaturamento.Name = "TxtFaturamento";
            this.TxtFaturamento.Size = new System.Drawing.Size(244, 31);
            this.TxtFaturamento.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Faturamento (em Dolar)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(930, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data fundacao";
            // 
            // DtDataFundacao
            // 
            this.DtDataFundacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtDataFundacao.Location = new System.Drawing.Point(936, 69);
            this.DtDataFundacao.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DtDataFundacao.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.DtDataFundacao.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.DtDataFundacao.Name = "DtDataFundacao";
            this.DtDataFundacao.Size = new System.Drawing.Size(204, 31);
            this.DtDataFundacao.TabIndex = 5;
            // 
            // TxtCidadeFundacao
            // 
            this.TxtCidadeFundacao.Location = new System.Drawing.Point(478, 69);
            this.TxtCidadeFundacao.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtCidadeFundacao.MaxLength = 50;
            this.TxtCidadeFundacao.Name = "TxtCidadeFundacao";
            this.TxtCidadeFundacao.Size = new System.Drawing.Size(442, 31);
            this.TxtCidadeFundacao.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cidade fundacao";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(20, 69);
            this.TxtNome.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtNome.MaxLength = 50;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(442, 31);
            this.TxtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(870, 352);
            this.BtnCadastrar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(150, 44);
            this.BtnCadastrar.TabIndex = 1;
            this.BtnCadastrar.Text = "&Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(1032, 352);
            this.BtnFechar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(150, 44);
            this.BtnFechar.TabIndex = 2;
            this.BtnFechar.Text = "&Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // FormManutencaoMontadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 419);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.GroupDados);
            this.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.Name = "FormManutencaoMontadora";
            this.Text = "Cadastro de montadora";
            this.Load += new System.EventHandler(this.FormManutencaoMontadora_Load);
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
        private System.Windows.Forms.TextBox TxtCidadeFundacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtDataFundacao;
        private System.Windows.Forms.MaskedTextBox TxtFaturamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox TxtLucroAnual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtQtdFabricas;
    }
}