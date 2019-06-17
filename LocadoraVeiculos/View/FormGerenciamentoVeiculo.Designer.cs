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
            this.vModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vNomeMontadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDisponivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alterar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.iId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
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
            this.GroupFiltros.Size = new System.Drawing.Size(510, 69);
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
            this.GroupDados.Size = new System.Drawing.Size(510, 347);
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
            this.vPlaca,
            this.vNomeMontadora,
            this.bDisponivel,
            this.Alterar,
            this.Excluir,
            this.iId});
            this.GridDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridDados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridDados.Location = new System.Drawing.Point(3, 16);
            this.GridDados.Name = "GridDados";
            this.GridDados.RowHeadersVisible = false;
            this.GridDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridDados.Size = new System.Drawing.Size(504, 328);
            this.GridDados.TabIndex = 0;
            this.GridDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDados_CellContentClick);
            // 
            // vModelo
            // 
            this.vModelo.DataPropertyName = "vModelo";
            this.vModelo.HeaderText = "Modelo";
            this.vModelo.Name = "vModelo";
            this.vModelo.Width = 125;
            // 
            // vPlaca
            // 
            this.vPlaca.DataPropertyName = "vPlaca";
            this.vPlaca.HeaderText = "Placa";
            this.vPlaca.Name = "vPlaca";
            this.vPlaca.Width = 60;
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
            this.bDisponivel.Width = 80;
            // 
            // Alterar
            // 
            this.Alterar.HeaderText = "Alterar";
            this.Alterar.Image = global::LocadoraVeiculos.Properties.Resources.update;
            this.Alterar.Name = "Alterar";
            this.Alterar.Width = 50;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Image = global::LocadoraVeiculos.Properties.Resources.delete;
            this.Excluir.Name = "Excluir";
            this.Excluir.Width = 50;
            // 
            // iId
            // 
            this.iId.DataPropertyName = "iId";
            this.iId.HeaderText = "iId";
            this.iId.Name = "iId";
            this.iId.Visible = false;
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(447, 440);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 23);
            this.BtnFechar.TabIndex = 4;
            this.BtnFechar.Text = "&Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(366, 440);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 3;
            this.BtnCadastrar.Text = "&Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // FormGerenciamentoVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 474);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.GroupDados);
            this.Controls.Add(this.GroupFiltros);
            this.Margin = new System.Windows.Forms.Padding(6);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn vModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn vPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNomeMontadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDisponivel;
        private System.Windows.Forms.DataGridViewImageColumn Alterar;
        private System.Windows.Forms.DataGridViewImageColumn Excluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn iId;
    }
}