namespace View
{
    partial class FormManutencaoVendedor : FormPadrao
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
            this.TxtSalario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GroupVendedor = new System.Windows.Forms.GroupBox();
            this.RbtInativo = new System.Windows.Forms.RadioButton();
            this.RbtAtivo = new System.Windows.Forms.RadioButton();
            this.DtDataDemissao = new System.Windows.Forms.DateTimePicker();
            this.LblDataDemissao = new System.Windows.Forms.Label();
            this.TxtPercentualComissao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DtDataAdmissao = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtConfirmacaoSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.GroupDados.SuspendLayout();
            this.GroupVendedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupDados
            // 
            this.GroupDados.Controls.Add(this.TxtSalario);
            this.GroupDados.Controls.Add(this.label8);
            this.GroupDados.Controls.Add(this.GroupVendedor);
            this.GroupDados.Controls.Add(this.DtDataDemissao);
            this.GroupDados.Controls.Add(this.LblDataDemissao);
            this.GroupDados.Controls.Add(this.TxtPercentualComissao);
            this.GroupDados.Controls.Add(this.label7);
            this.GroupDados.Controls.Add(this.DtDataAdmissao);
            this.GroupDados.Controls.Add(this.label6);
            this.GroupDados.Controls.Add(this.TxtCpf);
            this.GroupDados.Controls.Add(this.label5);
            this.GroupDados.Controls.Add(this.TxtConfirmacaoSenha);
            this.GroupDados.Controls.Add(this.label4);
            this.GroupDados.Controls.Add(this.TxtSenha);
            this.GroupDados.Controls.Add(this.label3);
            this.GroupDados.Controls.Add(this.TxtLogin);
            this.GroupDados.Controls.Add(this.label2);
            this.GroupDados.Controls.Add(this.TxtNome);
            this.GroupDados.Controls.Add(this.label1);
            this.GroupDados.Location = new System.Drawing.Point(12, 12);
            this.GroupDados.Name = "GroupDados";
            this.GroupDados.Size = new System.Drawing.Size(579, 180);
            this.GroupDados.TabIndex = 0;
            this.GroupDados.TabStop = false;
            // 
            // TxtSalario
            // 
            this.TxtSalario.Location = new System.Drawing.Point(455, 87);
            this.TxtSalario.MaxLength = 6;
            this.TxtSalario.Name = "TxtSalario";
            this.TxtSalario.Size = new System.Drawing.Size(118, 20);
            this.TxtSalario.TabIndex = 11;
            this.TxtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSalario_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Salário";
            // 
            // GroupVendedor
            // 
            this.GroupVendedor.Controls.Add(this.RbtInativo);
            this.GroupVendedor.Controls.Add(this.RbtAtivo);
            this.GroupVendedor.Location = new System.Drawing.Point(410, 126);
            this.GroupVendedor.Name = "GroupVendedor";
            this.GroupVendedor.Size = new System.Drawing.Size(163, 42);
            this.GroupVendedor.TabIndex = 18;
            this.GroupVendedor.TabStop = false;
            this.GroupVendedor.Text = "Estado";
            this.GroupVendedor.Visible = false;
            // 
            // RbtInativo
            // 
            this.RbtInativo.AutoSize = true;
            this.RbtInativo.Location = new System.Drawing.Point(69, 19);
            this.RbtInativo.Name = "RbtInativo";
            this.RbtInativo.Size = new System.Drawing.Size(57, 17);
            this.RbtInativo.TabIndex = 1;
            this.RbtInativo.Text = "Inativo";
            this.RbtInativo.UseVisualStyleBackColor = true;
            // 
            // RbtAtivo
            // 
            this.RbtAtivo.AutoSize = true;
            this.RbtAtivo.Checked = true;
            this.RbtAtivo.Location = new System.Drawing.Point(14, 19);
            this.RbtAtivo.Name = "RbtAtivo";
            this.RbtAtivo.Size = new System.Drawing.Size(49, 17);
            this.RbtAtivo.TabIndex = 0;
            this.RbtAtivo.TabStop = true;
            this.RbtAtivo.Text = "Ativo";
            this.RbtAtivo.UseVisualStyleBackColor = true;
            // 
            // DtDataDemissao
            // 
            this.DtDataDemissao.Enabled = false;
            this.DtDataDemissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtDataDemissao.Location = new System.Drawing.Point(272, 142);
            this.DtDataDemissao.Name = "DtDataDemissao";
            this.DtDataDemissao.Size = new System.Drawing.Size(132, 20);
            this.DtDataDemissao.TabIndex = 17;
            this.DtDataDemissao.Visible = false;
            // 
            // LblDataDemissao
            // 
            this.LblDataDemissao.AutoSize = true;
            this.LblDataDemissao.Location = new System.Drawing.Point(269, 125);
            this.LblDataDemissao.Name = "LblDataDemissao";
            this.LblDataDemissao.Size = new System.Drawing.Size(92, 13);
            this.LblDataDemissao.TabIndex = 16;
            this.LblDataDemissao.Text = "Data de demissão";
            this.LblDataDemissao.Visible = false;
            // 
            // TxtPercentualComissao
            // 
            this.TxtPercentualComissao.Location = new System.Drawing.Point(148, 143);
            this.TxtPercentualComissao.MaxLength = 2;
            this.TxtPercentualComissao.Name = "TxtPercentualComissao";
            this.TxtPercentualComissao.Size = new System.Drawing.Size(118, 20);
            this.TxtPercentualComissao.TabIndex = 15;
            this.TxtPercentualComissao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPercentualComissao_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Percentual comissão";
            // 
            // DtDataAdmissao
            // 
            this.DtDataAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtDataAdmissao.Location = new System.Drawing.Point(10, 143);
            this.DtDataAdmissao.Name = "DtDataAdmissao";
            this.DtDataAdmissao.Size = new System.Drawing.Size(132, 20);
            this.DtDataAdmissao.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data de admissão";
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(410, 36);
            this.TxtCpf.Mask = "999.999.999-99";
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(163, 20);
            this.TxtCpf.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "CPF";
            // 
            // TxtConfirmacaoSenha
            // 
            this.TxtConfirmacaoSenha.Location = new System.Drawing.Point(330, 87);
            this.TxtConfirmacaoSenha.MaxLength = 30;
            this.TxtConfirmacaoSenha.Name = "TxtConfirmacaoSenha";
            this.TxtConfirmacaoSenha.PasswordChar = '*';
            this.TxtConfirmacaoSenha.Size = new System.Drawing.Size(118, 20);
            this.TxtConfirmacaoSenha.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirmar senha";
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(206, 87);
            this.TxtSenha.MaxLength = 30;
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(118, 20);
            this.TxtSenha.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha";
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(10, 87);
            this.TxtLogin.MaxLength = 50;
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(190, 20);
            this.TxtLogin.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(10, 36);
            this.TxtNome.MaxLength = 50;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(394, 20);
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
            this.BtnCadastrar.Location = new System.Drawing.Point(435, 219);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 1;
            this.BtnCadastrar.Text = "&Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(516, 219);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 23);
            this.BtnFechar.TabIndex = 2;
            this.BtnFechar.Text = "&Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // FormManutencaoVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 252);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.GroupDados);
            this.Name = "FormManutencaoVendedor";
            this.Text = "Cadastro de vendedor";
            this.Load += new System.EventHandler(this.FormManutencaoVendedor_Load);
            this.GroupDados.ResumeLayout(false);
            this.GroupDados.PerformLayout();
            this.GroupVendedor.ResumeLayout(false);
            this.GroupVendedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupDados;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.TextBox TxtConfirmacaoSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox TxtCpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DtDataAdmissao;
        private System.Windows.Forms.TextBox TxtPercentualComissao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DtDataDemissao;
        private System.Windows.Forms.Label LblDataDemissao;
        private System.Windows.Forms.RadioButton RbtInativo;
        private System.Windows.Forms.RadioButton RbtAtivo;
        private System.Windows.Forms.GroupBox GroupVendedor;
        private System.Windows.Forms.TextBox TxtSalario;
        private System.Windows.Forms.Label label8;
    }
}