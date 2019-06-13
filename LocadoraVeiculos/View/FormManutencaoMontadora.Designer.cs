namespace View
{
    partial class FormManutencaoMontadora : FormPadrao
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
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.GroupDados = new System.Windows.Forms.GroupBox();
            this.TxtFaturamento = new System.Windows.Forms.TextBox();
            this.TxtLucroAnual = new System.Windows.Forms.TextBox();
            this.TxtQtdFabricas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DtDataFundacao = new System.Windows.Forms.DateTimePicker();
            this.TxtCidadeFundacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupDados.SuspendLayout();
            this.SuspendLayout();
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
            // GroupDados
            // 
            this.GroupDados.Controls.Add(this.TxtFaturamento);
            this.GroupDados.Controls.Add(this.TxtLucroAnual);
            this.GroupDados.Controls.Add(this.TxtQtdFabricas);
            this.GroupDados.Controls.Add(this.label6);
            this.GroupDados.Controls.Add(this.label5);
            this.GroupDados.Controls.Add(this.label4);
            this.GroupDados.Controls.Add(this.label3);
            this.GroupDados.Controls.Add(this.DtDataFundacao);
            this.GroupDados.Controls.Add(this.TxtCidadeFundacao);
            this.GroupDados.Controls.Add(this.label2);
            this.GroupDados.Controls.Add(this.TxtNome);
            this.GroupDados.Controls.Add(this.label1);
            this.GroupDados.Location = new System.Drawing.Point(12, 12);
            this.GroupDados.Name = "GroupDados";
            this.GroupDados.Size = new System.Drawing.Size(579, 129);
            this.GroupDados.TabIndex = 0;
            this.GroupDados.TabStop = false;
            // 
            // TxtFaturamento
            // 
            this.TxtFaturamento.Location = new System.Drawing.Point(10, 96);
            this.TxtFaturamento.MaxLength = 7;
            this.TxtFaturamento.Name = "TxtFaturamento";
            this.TxtFaturamento.Size = new System.Drawing.Size(114, 20);
            this.TxtFaturamento.TabIndex = 7;
            this.TxtFaturamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFaturamento_KeyPress);
            // 
            // TxtLucroAnual
            // 
            this.TxtLucroAnual.Location = new System.Drawing.Point(140, 96);
            this.TxtLucroAnual.MaxLength = 7;
            this.TxtLucroAnual.Name = "TxtLucroAnual";
            this.TxtLucroAnual.Size = new System.Drawing.Size(105, 20);
            this.TxtLucroAnual.TabIndex = 9;
            this.TxtLucroAnual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLucroAnual_KeyPress);
            // 
            // TxtQtdFabricas
            // 
            this.TxtQtdFabricas.Location = new System.Drawing.Point(257, 96);
            this.TxtQtdFabricas.MaxLength = 7;
            this.TxtQtdFabricas.Name = "TxtQtdFabricas";
            this.TxtQtdFabricas.Size = new System.Drawing.Size(105, 20);
            this.TxtQtdFabricas.TabIndex = 12;
            this.TxtQtdFabricas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQtdFabricas_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Qtd. de fábricas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lucro anual (em Dolar)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Faturamento (em Dolar)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de fundação";
            // 
            // DtDataFundacao
            // 
            this.DtDataFundacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtDataFundacao.Location = new System.Drawing.Point(468, 36);
            this.DtDataFundacao.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.DtDataFundacao.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.DtDataFundacao.Name = "DtDataFundacao";
            this.DtDataFundacao.Size = new System.Drawing.Size(104, 20);
            this.DtDataFundacao.TabIndex = 5;
            // 
            // TxtCidadeFundacao
            // 
            this.TxtCidadeFundacao.Location = new System.Drawing.Point(239, 36);
            this.TxtCidadeFundacao.MaxLength = 50;
            this.TxtCidadeFundacao.Name = "TxtCidadeFundacao";
            this.TxtCidadeFundacao.Size = new System.Drawing.Size(223, 20);
            this.TxtCidadeFundacao.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cidade de fundação";
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
            // FormManutencaoMontadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 218);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.GroupDados);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtQtdFabricas;
        private System.Windows.Forms.TextBox TxtFaturamento;
        private System.Windows.Forms.TextBox TxtLucroAnual;
    }
}