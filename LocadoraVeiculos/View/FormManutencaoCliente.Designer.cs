namespace View
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
            this.GroupSexo = new System.Windows.Forms.GroupBox();
            this.RbtFeminino = new System.Windows.Forms.RadioButton();
            this.RbtMasculino = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.TxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.GroupDados.SuspendLayout();
            this.GroupSexo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupDados
            // 
            this.GroupDados.Controls.Add(this.TxtTelefone);
            this.GroupDados.Controls.Add(this.TxtCelular);
            this.GroupDados.Controls.Add(this.GroupSexo);
            this.GroupDados.Controls.Add(this.label4);
            this.GroupDados.Controls.Add(this.TxtEmail);
            this.GroupDados.Controls.Add(this.label3);
            this.GroupDados.Controls.Add(this.label2);
            this.GroupDados.Controls.Add(this.TxtIdade);
            this.GroupDados.Controls.Add(this.label7);
            this.GroupDados.Controls.Add(this.TxtCpf);
            this.GroupDados.Controls.Add(this.label5);
            this.GroupDados.Controls.Add(this.TxtNome);
            this.GroupDados.Controls.Add(this.label1);
            this.GroupDados.Location = new System.Drawing.Point(24, 23);
            this.GroupDados.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.GroupDados.Name = "GroupDados";
            this.GroupDados.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.GroupDados.Size = new System.Drawing.Size(1158, 248);
            this.GroupDados.TabIndex = 0;
            this.GroupDados.TabStop = false;
            this.GroupDados.Text = "Cliente";
            // 
            // TxtCelular
            // 
            this.TxtCelular.Location = new System.Drawing.Point(380, 163);
            this.TxtCelular.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtCelular.Mask = "(99) 99999-9999";
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(196, 31);
            this.TxtCelular.TabIndex = 11;
            // 
            // GroupSexo
            // 
            this.GroupSexo.Controls.Add(this.RbtFeminino);
            this.GroupSexo.Controls.Add(this.RbtMasculino);
            this.GroupSexo.Location = new System.Drawing.Point(592, 131);
            this.GroupSexo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.GroupSexo.Name = "GroupSexo";
            this.GroupSexo.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.GroupSexo.Size = new System.Drawing.Size(332, 81);
            this.GroupSexo.TabIndex = 12;
            this.GroupSexo.TabStop = false;
            this.GroupSexo.Text = "Sexo";
            this.GroupSexo.Visible = false;
            // 
            // RbtFeminino
            // 
            this.RbtFeminino.AutoSize = true;
            this.RbtFeminino.Enabled = false;
            this.RbtFeminino.Location = new System.Drawing.Point(186, 37);
            this.RbtFeminino.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RbtFeminino.Name = "RbtFeminino";
            this.RbtFeminino.Size = new System.Drawing.Size(131, 29);
            this.RbtFeminino.TabIndex = 1;
            this.RbtFeminino.Text = "Feminino";
            this.RbtFeminino.UseVisualStyleBackColor = true;
            // 
            // RbtMasculino
            // 
            this.RbtMasculino.AutoSize = true;
            this.RbtMasculino.Checked = true;
            this.RbtMasculino.Enabled = false;
            this.RbtMasculino.Location = new System.Drawing.Point(28, 37);
            this.RbtMasculino.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RbtMasculino.Name = "RbtMasculino";
            this.RbtMasculino.Size = new System.Drawing.Size(141, 29);
            this.RbtMasculino.TabIndex = 0;
            this.RbtMasculino.TabStop = true;
            this.RbtMasculino.Text = "Masculino";
            this.RbtMasculino.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Celular";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(20, 163);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtEmail.MaxLength = 40;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(344, 31);
            this.TxtEmail.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(904, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Telefone";
            // 
            // TxtIdade
            // 
            this.TxtIdade.Location = new System.Drawing.Point(762, 69);
            this.TxtIdade.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtIdade.MaxLength = 2;
            this.TxtIdade.Name = "TxtIdade";
            this.TxtIdade.Size = new System.Drawing.Size(132, 31);
            this.TxtIdade.TabIndex = 5;
            this.TxtIdade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdade_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(756, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Idade";
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(554, 69);
            this.TxtCpf.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtCpf.Mask = "999.999.999-99";
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(192, 31);
            this.TxtCpf.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "CPF";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(20, 69);
            this.TxtNome.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtNome.MaxLength = 50;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(518, 31);
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
            this.BtnCadastrar.Location = new System.Drawing.Point(870, 683);
            this.BtnCadastrar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(150, 44);
            this.BtnCadastrar.TabIndex = 2;
            this.BtnCadastrar.Text = "&Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(1032, 683);
            this.BtnFechar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(150, 44);
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
            this.groupBox1.Location = new System.Drawing.Point(22, 283);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(1158, 340);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereco";
            // 
            // TxtObservacao
            // 
            this.TxtObservacao.Location = new System.Drawing.Point(176, 271);
            this.TxtObservacao.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtObservacao.MaxLength = 50;
            this.TxtObservacao.Name = "TxtObservacao";
            this.TxtObservacao.Size = new System.Drawing.Size(966, 31);
            this.TxtObservacao.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(170, 238);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 25);
            this.label16.TabIndex = 14;
            this.label16.Text = "Observação";
            // 
            // TxtCep
            // 
            this.TxtCep.Location = new System.Drawing.Point(22, 271);
            this.TxtCep.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtCep.Mask = "99999-999";
            this.TxtCep.Name = "TxtCep";
            this.TxtCep.Size = new System.Drawing.Size(138, 31);
            this.TxtCep.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 238);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 25);
            this.label14.TabIndex = 12;
            this.label14.Text = "CEP";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1004, 146);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 25);
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
            this.CboEstado.Location = new System.Drawing.Point(1010, 175);
            this.CboEstado.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CboEstado.Name = "CboEstado";
            this.CboEstado.Size = new System.Drawing.Size(132, 33);
            this.CboEstado.TabIndex = 11;
            // 
            // TxtCidade
            // 
            this.TxtCidade.Location = new System.Drawing.Point(476, 177);
            this.TxtCidade.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtCidade.MaxLength = 50;
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(518, 31);
            this.TxtCidade.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(470, 146);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 25);
            this.label12.TabIndex = 8;
            this.label12.Text = "Cidade";
            // 
            // TxtBairro
            // 
            this.TxtBairro.Location = new System.Drawing.Point(22, 177);
            this.TxtBairro.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtBairro.MaxLength = 50;
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(438, 31);
            this.TxtBairro.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 146);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 25);
            this.label11.TabIndex = 6;
            this.label11.Text = "Bairro";
            // 
            // TxtComplemento
            // 
            this.TxtComplemento.Location = new System.Drawing.Point(704, 79);
            this.TxtComplemento.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtComplemento.MaxLength = 50;
            this.TxtComplemento.Name = "TxtComplemento";
            this.TxtComplemento.Size = new System.Drawing.Size(438, 31);
            this.TxtComplemento.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(698, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "Complemento";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(556, 79);
            this.TxtNumero.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtNumero.MaxLength = 5;
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(132, 31);
            this.TxtNumero.TabIndex = 3;
            this.TxtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(550, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Número";
            // 
            // TxtLogradouro
            // 
            this.TxtLogradouro.Location = new System.Drawing.Point(22, 79);
            this.TxtLogradouro.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtLogradouro.MaxLength = 50;
            this.TxtLogradouro.Name = "TxtLogradouro";
            this.TxtLogradouro.Size = new System.Drawing.Size(518, 31);
            this.TxtLogradouro.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Logradouro";
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Location = new System.Drawing.Point(909, 69);
            this.TxtTelefone.Mask = "(99) 9999-9999";
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(231, 31);
            this.TxtTelefone.TabIndex = 7;
            // 
            // FormManutencaoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 750);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.GroupDados);
            this.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GroupSexo;
        private System.Windows.Forms.RadioButton RbtFeminino;
        private System.Windows.Forms.RadioButton RbtMasculino;
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
        private System.Windows.Forms.MaskedTextBox TxtTelefone;
    }
}