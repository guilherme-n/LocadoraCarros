namespace View
{
    partial class FormLocacaoVeiculos : FormPadrao
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
            this.BtnFechar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CboMarca = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CboCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CboVeiculo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDiaria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CboFormaPagamento = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtVendedorLogado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtValorTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.DtInicioAluguel = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(464, 172);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 23);
            this.BtnFechar.TabIndex = 3;
            this.BtnFechar.Text = "&Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CboMarca);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CboCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CboVeiculo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Marca";
            // 
            // CboMarca
            // 
            this.CboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboMarca.FormattingEnabled = true;
            this.CboMarca.Location = new System.Drawing.Point(9, 32);
            this.CboMarca.Name = "CboMarca";
            this.CboMarca.Size = new System.Drawing.Size(118, 21);
            this.CboMarca.TabIndex = 1;
            this.CboMarca.SelectedIndexChanged += new System.EventHandler(this.CboMarca_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente";
            // 
            // CboCliente
            // 
            this.CboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCliente.FormattingEnabled = true;
            this.CboCliente.Location = new System.Drawing.Point(257, 32);
            this.CboCliente.Name = "CboCliente";
            this.CboCliente.Size = new System.Drawing.Size(264, 21);
            this.CboCliente.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Veículo";
            // 
            // CboVeiculo
            // 
            this.CboVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboVeiculo.FormattingEnabled = true;
            this.CboVeiculo.Location = new System.Drawing.Point(133, 32);
            this.CboVeiculo.Name = "CboVeiculo";
            this.CboVeiculo.Size = new System.Drawing.Size(118, 21);
            this.CboVeiculo.TabIndex = 3;
            this.CboVeiculo.SelectedIndexChanged += new System.EventHandler(this.CboVeiculo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Diárias";
            // 
            // TxtDiaria
            // 
            this.TxtDiaria.Location = new System.Drawing.Point(9, 32);
            this.TxtDiaria.MaxLength = 3;
            this.TxtDiaria.Name = "TxtDiaria";
            this.TxtDiaria.Size = new System.Drawing.Size(41, 20);
            this.TxtDiaria.TabIndex = 1;
            this.TxtDiaria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.TxtDiaria.Validated += new System.EventHandler(this.TxtDiaria_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Forma pagamento";
            // 
            // CboFormaPagamento
            // 
            this.CboFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboFormaPagamento.FormattingEnabled = true;
            this.CboFormaPagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão de crédito",
            "Cheque"});
            this.CboFormaPagamento.Location = new System.Drawing.Point(152, 31);
            this.CboFormaPagamento.Name = "CboFormaPagamento";
            this.CboFormaPagamento.Size = new System.Drawing.Size(121, 21);
            this.CboFormaPagamento.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.DtInicioAluguel);
            this.groupBox2.Controls.Add(this.TxtVendedorLogado);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtValorTotal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.CboFormaPagamento);
            this.groupBox2.Controls.Add(this.TxtDiaria);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // TxtVendedorLogado
            // 
            this.TxtVendedorLogado.Location = new System.Drawing.Point(389, 32);
            this.TxtVendedorLogado.MaxLength = 10;
            this.TxtVendedorLogado.Name = "TxtVendedorLogado";
            this.TxtVendedorLogado.ReadOnly = true;
            this.TxtVendedorLogado.Size = new System.Drawing.Size(132, 20);
            this.TxtVendedorLogado.TabIndex = 9;
            this.TxtVendedorLogado.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Vendedor logado";
            // 
            // TxtValorTotal
            // 
            this.TxtValorTotal.Location = new System.Drawing.Point(56, 32);
            this.TxtValorTotal.MaxLength = 10;
            this.TxtValorTotal.Name = "TxtValorTotal";
            this.TxtValorTotal.ReadOnly = true;
            this.TxtValorTotal.Size = new System.Drawing.Size(90, 20);
            this.TxtValorTotal.TabIndex = 3;
            this.TxtValorTotal.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Valor total";
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(383, 172);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 2;
            this.BtnCadastrar.Text = "&Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Início do aluguel";
            // 
            // DtInicioAluguel
            // 
            this.DtInicioAluguel.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtInicioAluguel.Location = new System.Drawing.Point(279, 32);
            this.DtInicioAluguel.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.DtInicioAluguel.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.DtInicioAluguel.Name = "DtInicioAluguel";
            this.DtInicioAluguel.Size = new System.Drawing.Size(104, 20);
            this.DtInicioAluguel.TabIndex = 7;
            // 
            // FormLocacaoVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 205);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormLocacaoVeiculos";
            this.Text = "Locação de veículo";
            this.Load += new System.EventHandler(this.FormLocacaoVeiculos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboVeiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboCliente;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.TextBox TxtDiaria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboFormaPagamento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtValorTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboMarca;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.TextBox TxtVendedorLogado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DtInicioAluguel;
    }
}