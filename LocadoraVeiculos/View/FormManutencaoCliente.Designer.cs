namespace LocadoraVeiculos.View
{
    partial class FormManutencaoCliente : FormPadrao
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
            this.TxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.DtDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.GroupSexo = new System.Windows.Forms.GroupBox();
            this.RbtFeminino = new System.Windows.Forms.RadioButton();
            this.RbtMasculino = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTelefone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIdade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtObservacao = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtCep = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CboEstado = new System.Windows.Forms.ComboBox();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtComplemento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtLogradouro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GroupDados.SuspendLayout();
            this.GroupSexo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupDados
            // 
            this.GroupDados.Controls.Add(this.TxtCelular);
            this.GroupDados.Controls.Add(this.DtDataCadastro);
            this.GroupDados.Controls.Add(this.label6);
            this.GroupDados.Controls.Add(this.GroupSexo);
            this.GroupDados.Controls.Add(this.label4);
            this.GroupDados.Controls.Add(this.TxtEmail);
            this.GroupDados.Controls.Add(this.label3);
            this.GroupDados.Controls.Add(this.TxtTelefone);
            this.GroupDados.Controls.Add(this.label2);
            this.GroupDados.Controls.Add(this.TxtIdade);
            this.GroupDados.Controls.Add(this.label7);
            this.GroupDados.Controls.Add(this.TxtCpf);
            this.GroupDados.Controls.Add(this.label5);
            this.GroupDados.Controls.Add(this.TxtNome);
            this.GroupDados.Controls.Add(this.label1);
            this.GroupDados.Location = new System.Drawing.Point(12, 12);
            this.GroupDados.Name = "GroupDados";
            this.GroupDados.Size = new System.Drawing.Size(579, 129);
            this.GroupDados.TabIndex = 0;
            this.GroupDados.TabStop = false;
            this.GroupDados.Text = "Cliente";
            // 
            // TxtCelular
            // 
            this.TxtCelular.Location = new System.Drawing.Point(190, 85);
            this.TxtCelular.Mask = "(99) 99999-9999";
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(100, 20);
            this.TxtCelular.TabIndex = 11;
            // 
            // DtDataCadastro
            // 
            this.DtDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtDataCadastro.Location = new System.Drawing.Point(468, 86);
            this.DtDataCadastro.Name = "DtDataCadastro";
            this.DtDataCadastro.Size = new System.Drawing.Size(104, 20);
            this.DtDataCadastro.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Data de cadastro";
            // 
            // GroupSexo
            // 
            this.GroupSexo.Controls.Add(this.RbtFeminino);
            this.GroupSexo.Controls.Add(this.RbtMasculino);
            this.GroupSexo.Location = new System.Drawing.Point(296, 68);
            this.GroupSexo.Name = "GroupSexo";
            this.GroupSexo.Size = new System.Drawing.Size(166, 42);
            this.GroupSexo.TabIndex = 12;
            this.GroupSexo.TabStop = false;
            this.GroupSexo.Text = "Sexo";
            this.GroupSexo.Visible = false;
            // 
            // RbtFeminino
            // 
            this.RbtFeminino.AutoSize = true;
            this.RbtFeminino.Enabled = false;
            this.RbtFeminino.Location = new System.Drawing.Point(93, 19);
            this.RbtFeminino.Name = "RbtFeminino";
            this.RbtFeminino.Size = new System.Drawing.Size(67, 17);
            this.RbtFeminino.TabIndex = 1;
            this.RbtFeminino.Text = "Feminino";
            this.RbtFeminino.UseVisualStyleBackColor = true;
            // 
            // RbtMasculino
            // 
            this.RbtMasculino.AutoSize = true;
            this.RbtMasculino.Checked = true;
            this.RbtMasculino.Enabled = false;
            this.RbtMasculino.Location = new System.Drawing.Point(14, 19);
            this.RbtMasculino.Name = "RbtMasculino";
            this.RbtMasculino.Size = new System.Drawing.Size(73, 17);
            this.RbtMasculino.TabIndex = 0;
            this.RbtMasculino.TabStop = true;
            this.RbtMasculino.Text = "Masculino";
            this.RbtMasculino.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Celular";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(10, 85);
            this.TxtEmail.MaxLength = 2;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(174, 20);
            this.TxtEmail.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Location = new System.Drawing.Point(455, 36);
            this.TxtTelefone.MaxLength = 2;
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(117, 20);
            this.TxtTelefone.TabIndex = 7;
            this.TxtTelefone.Text = "(99) 9999-9999";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Telefone";
            // 
            // TxtIdade
            // 
            this.TxtIdade.Location = new System.Drawing.Point(381, 36);
            this.TxtIdade.MaxLength = 2;
            this.TxtIdade.Name = "TxtIdade";
            this.TxtIdade.Size = new System.Drawing.Size(68, 20);
            this.TxtIdade.TabIndex = 5;
            this.TxtIdade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdade_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(378, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Idade";
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(277, 36);
            this.TxtCpf.Mask = "999.999.999-99";
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(98, 20);
            this.TxtCpf.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "CPF";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(10, 36);
            this.TxtNome.MaxLength = 50;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(261, 20);
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
            this.BtnCadastrar.Location = new System.Drawing.Point(435, 355);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 2;
            this.BtnCadastrar.Text = "&Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(516, 355);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 23);
            this.BtnFechar.TabIndex = 3;
            this.BtnFechar.Text = "&Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtObservacao);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.TxtCep);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.CboEstado);
            this.groupBox1.Controls.Add(this.TxtCidade);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TxtBairro);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TxtComplemento);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxtNumero);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtLogradouro);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(11, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 177);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereco";
            // 
            // TxtObservacao
            // 
            this.TxtObservacao.Location = new System.Drawing.Point(88, 141);
            this.TxtObservacao.MaxLength = 50;
            this.TxtObservacao.Name = "TxtObservacao";
            this.TxtObservacao.Size = new System.Drawing.Size(485, 20);
            this.TxtObservacao.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(85, 124);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Observação";
            // 
            // TxtCep
            // 
            this.TxtCep.Location = new System.Drawing.Point(11, 141);
            this.TxtCep.Mask = "99999-999";
            this.TxtCep.Name = "TxtCep";
            this.TxtCep.Size = new System.Drawing.Size(71, 20);
            this.TxtCep.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "CEP";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(502, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Estado";
            // 
            // CboEstado
            // 
            this.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEstado.FormattingEnabled = true;
            this.CboEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.CboEstado.Location = new System.Drawing.Point(505, 91);
            this.CboEstado.Name = "CboEstado";
            this.CboEstado.Size = new System.Drawing.Size(68, 21);
            this.CboEstado.TabIndex = 11;
            // 
            // TxtCidade
            // 
            this.TxtCidade.Location = new System.Drawing.Point(238, 92);
            this.TxtCidade.MaxLength = 50;
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(261, 20);
            this.TxtCidade.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(235, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Cidade";
            // 
            // TxtBairro
            // 
            this.TxtBairro.Location = new System.Drawing.Point(11, 92);
            this.TxtBairro.MaxLength = 50;
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(221, 20);
            this.TxtBairro.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Bairro";
            // 
            // TxtComplemento
            // 
            this.TxtComplemento.Location = new System.Drawing.Point(352, 41);
            this.TxtComplemento.MaxLength = 50;
            this.TxtComplemento.Name = "TxtComplemento";
            this.TxtComplemento.Size = new System.Drawing.Size(221, 20);
            this.TxtComplemento.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(349, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Complemento";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(278, 41);
            this.TxtNumero.MaxLength = 5;
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(68, 20);
            this.TxtNumero.TabIndex = 3;
            this.TxtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Número";
            // 
            // TxtLogradouro
            // 
            this.TxtLogradouro.Location = new System.Drawing.Point(11, 41);
            this.TxtLogradouro.MaxLength = 50;
            this.TxtLogradouro.Name = "TxtLogradouro";
            this.TxtLogradouro.Size = new System.Drawing.Size(261, 20);
            this.TxtLogradouro.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Logradouro";
            // 
            // FormManutencaoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 390);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.GroupDados);
            this.Name = "FormManutencaoCliente";
            this.Text = "Cadastro de cliente";
            this.Load += new System.EventHandler(this.FormManutencaoCliente_Load);
            this.GroupDados.ResumeLayout(false);
            this.GroupDados.PerformLayout();
            this.GroupSexo.ResumeLayout(false);
            this.GroupSexo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupDados;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox TxtCpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtIdade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtTelefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GroupSexo;
        private System.Windows.Forms.RadioButton RbtFeminino;
        private System.Windows.Forms.RadioButton RbtMasculino;
        private System.Windows.Forms.DateTimePicker DtDataCadastro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox TxtCelular;
        private System.Windows.Forms.TextBox TxtLogradouro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtComplemento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CboEstado;
        private System.Windows.Forms.MaskedTextBox TxtCep;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtObservacao;
        private System.Windows.Forms.Label label16;
    }
}