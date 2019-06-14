namespace View
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
            this.TxtQuilometragem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtValorDiaria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCor = new System.Windows.Forms.TextBox();
            this.CboMontadora = new System.Windows.Forms.ComboBox();
            this.TxtAnoFabricacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.GroupDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupDados
            // 
            this.GroupDados.Controls.Add(this.TxtQuilometragem);
            this.GroupDados.Controls.Add(this.label7);
            this.GroupDados.Controls.Add(this.TxtPlaca);
            this.GroupDados.Controls.Add(this.label6);
            this.GroupDados.Controls.Add(this.TxtValorDiaria);
            this.GroupDados.Controls.Add(this.label5);
            this.GroupDados.Controls.Add(this.TxtCor);
            this.GroupDados.Controls.Add(this.CboMontadora);
            this.GroupDados.Controls.Add(this.TxtAnoFabricacao);
            this.GroupDados.Controls.Add(this.label4);
            this.GroupDados.Controls.Add(this.label3);
            this.GroupDados.Controls.Add(this.label2);
            this.GroupDados.Controls.Add(this.TxtModelo);
            this.GroupDados.Controls.Add(this.label1);
            this.GroupDados.Location = new System.Drawing.Point(12, 12);
            this.GroupDados.Name = "GroupDados";
            this.GroupDados.Size = new System.Drawing.Size(579, 129);
            this.GroupDados.TabIndex = 0;
            this.GroupDados.TabStop = false;
            // 
            // TxtQuilometragem
            // 
            this.TxtQuilometragem.Location = new System.Drawing.Point(330, 96);
            this.TxtQuilometragem.MaxLength = 10;
            this.TxtQuilometragem.Name = "TxtQuilometragem";
            this.TxtQuilometragem.Size = new System.Drawing.Size(114, 20);
            this.TxtQuilometragem.TabIndex = 13;
            this.TxtQuilometragem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQuilometragem_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Quilometragem";
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.Location = new System.Drawing.Point(253, 96);
            this.TxtPlaca.Mask = ">LLL-0000";
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(71, 20);
            this.TxtPlaca.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Placa";
            // 
            // TxtValorDiaria
            // 
            this.TxtValorDiaria.Location = new System.Drawing.Point(130, 96);
            this.TxtValorDiaria.MaxLength = 8;
            this.TxtValorDiaria.Name = "TxtValorDiaria";
            this.TxtValorDiaria.Size = new System.Drawing.Size(114, 20);
            this.TxtValorDiaria.TabIndex = 9;
            this.TxtValorDiaria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorDiaria_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor diária";
            // 
            // TxtCor
            // 
            this.TxtCor.Location = new System.Drawing.Point(10, 96);
            this.TxtCor.MaxLength = 50;
            this.TxtCor.Name = "TxtCor";
            this.TxtCor.Size = new System.Drawing.Size(114, 20);
            this.TxtCor.TabIndex = 7;
            // 
            // CboMontadora
            // 
            this.CboMontadora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboMontadora.FormattingEnabled = true;
            this.CboMontadora.Location = new System.Drawing.Point(239, 35);
            this.CboMontadora.Name = "CboMontadora";
            this.CboMontadora.Size = new System.Drawing.Size(223, 21);
            this.CboMontadora.TabIndex = 3;
            // 
            // TxtAnoFabricacao
            // 
            this.TxtAnoFabricacao.Location = new System.Drawing.Point(468, 36);
            this.TxtAnoFabricacao.MaxLength = 4;
            this.TxtAnoFabricacao.Name = "TxtAnoFabricacao";
            this.TxtAnoFabricacao.Size = new System.Drawing.Size(105, 20);
            this.TxtAnoFabricacao.TabIndex = 5;
            this.TxtAnoFabricacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAnoFabricacao_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ano de fabricação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Montadora";
            // 
            // TxtModelo
            // 
            this.TxtModelo.Location = new System.Drawing.Point(10, 36);
            this.TxtModelo.MaxLength = 50;
            this.TxtModelo.Name = "TxtModelo";
            this.TxtModelo.Size = new System.Drawing.Size(223, 20);
            this.TxtModelo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo";
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(435, 166);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 1;
            this.BtnCadastrar.Text = "&Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(516, 166);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 23);
            this.BtnFechar.TabIndex = 2;
            this.BtnFechar.Text = "&Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // FormManutencaoVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 195);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.GroupDados);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormManutencaoVeiculo";
            this.Text = "Cadastro de veículo";
            this.Load += new System.EventHandler(this.FormManutencaoVeiculo_Load);
            this.GroupDados.ResumeLayout(false);
            this.GroupDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupDados;
        private System.Windows.Forms.TextBox TxtModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAnoFabricacao;
        private System.Windows.Forms.ComboBox CboMontadora;
        private System.Windows.Forms.TextBox TxtCor;
        private System.Windows.Forms.TextBox TxtValorDiaria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox TxtPlaca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtQuilometragem;
        private System.Windows.Forms.Label label7;
    }
}