namespace View
{
    partial class FormGerenciamentoVeiculo : FormPadrao
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
            this.GroupFiltros = new System.Windows.Forms.GroupBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtModelo = new System.Windows.Forms.TextBox();
            this.GroupDados = new System.Windows.Forms.GroupBox();
            this.GridDados = new System.Windows.Forms.DataGridView();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.vModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vNomeMontadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDisponivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupFiltros.SuspendLayout();
            this.GroupDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDados)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupFiltros
            // 
            this.GroupFiltros.Controls.Add(this.BtnConsultar);
            this.GroupFiltros.Controls.Add(this.label1);
            this.GroupFiltros.Controls.Add(this.TxtModelo);
            this.GroupFiltros.Location = new System.Drawing.Point(12, 12);
            this.GroupFiltros.Name = "GroupFiltros";
            this.GroupFiltros.Size = new System.Drawing.Size(412, 69);
            this.GroupFiltros.TabIndex = 0;
            this.GroupFiltros.TabStop = false;
            this.GroupFiltros.Text = "Filtros";
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(239, 34);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultar.TabIndex = 2;
            this.BtnConsultar.Text = "&Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
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
            // TxtModelo
            // 
            this.TxtModelo.Location = new System.Drawing.Point(10, 36);
            this.TxtModelo.MaxLength = 50;
            this.TxtModelo.Name = "TxtModelo";
            this.TxtModelo.Size = new System.Drawing.Size(223, 20);
            this.TxtModelo.TabIndex = 1;
            // 
            // GroupDados
            // 
            this.GroupDados.Controls.Add(this.GridDados);
            this.GroupDados.Location = new System.Drawing.Point(12, 87);
            this.GroupDados.Name = "GroupDados";
            this.GroupDados.Size = new System.Drawing.Size(412, 433);
            this.GroupDados.TabIndex = 1;
            this.GroupDados.TabStop = false;
            // 
            // GridDados
            // 
            this.GridDados.AllowUserToAddRows = false;
            this.GridDados.AllowUserToDeleteRows = false;
            this.GridDados.AllowUserToResizeColumns = false;
            this.GridDados.AllowUserToResizeRows = false;
            this.GridDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vModelo,
            this.vNomeMontadora,
            this.bDisponivel,
            this.iId});
            this.GridDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridDados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridDados.Location = new System.Drawing.Point(3, 16);
            this.GridDados.Name = "GridDados";
            this.GridDados.RowHeadersVisible = false;
            this.GridDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridDados.Size = new System.Drawing.Size(406, 414);
            this.GridDados.TabIndex = 0;
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(349, 526);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 23);
            this.BtnFechar.TabIndex = 4;
            this.BtnFechar.Text = "&Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(268, 526);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 3;
            this.BtnCadastrar.Text = "&Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(187, 526);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 2;
            this.BtnAlterar.Text = "&Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // vModelo
            // 
            this.vModelo.DataPropertyName = "vModelo";
            this.vModelo.HeaderText = "Modelo";
            this.vModelo.Name = "vModelo";
            this.vModelo.Width = 165;
            // 
            // vNomeMontadora
            // 
            this.vNomeMontadora.DataPropertyName = "vNomeMontadora";
            this.vNomeMontadora.HeaderText = "Montadora";
            this.vNomeMontadora.Name = "vNomeMontadora";
            this.vNomeMontadora.Width = 120;
            // 
            // bDisponivel
            // 
            this.bDisponivel.DataPropertyName = "bDisponivel";
            this.bDisponivel.HeaderText = "Disponível";
            this.bDisponivel.Name = "bDisponivel";
            // 
            // iId
            // 
            this.iId.DataPropertyName = "iId";
            this.iId.HeaderText = "iId";
            this.iId.Name = "iId";
            this.iId.Visible = false;
            // 
            // FormGerenciamentoVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 561);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.GroupDados);
            this.Controls.Add(this.GroupFiltros);
            this.Name = "FormGerenciamentoVeiculo";
            this.Text = "Gerenciamento de veículos";
            this.GroupFiltros.ResumeLayout(false);
            this.GroupFiltros.PerformLayout();
            this.GroupDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupFiltros;
        private System.Windows.Forms.TextBox TxtModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.GroupBox GroupDados;
        private System.Windows.Forms.DataGridView GridDados;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn vModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNomeMontadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDisponivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn iId;
    }
}