namespace LocadoraVeiculos.View
{
    partial class FormGerenciamentoCliente : FormPadrao
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
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.GroupDados = new System.Windows.Forms.GroupBox();
            this.GridDados = new System.Windows.Forms.DataGridView();
            this.GroupFiltros = new System.Windows.Forms.GroupBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDados)).BeginInit();
            this.GroupFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(1070, 964);
            this.BtnAlterar.Margin = new System.Windows.Forms.Padding(6);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(150, 44);
            this.BtnAlterar.TabIndex = 2;
            this.BtnAlterar.Text = "&Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(1232, 964);
            this.BtnCadastrar.Margin = new System.Windows.Forms.Padding(6);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(150, 44);
            this.BtnCadastrar.TabIndex = 3;
            this.BtnCadastrar.Text = "&Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(1394, 964);
            this.BtnFechar.Margin = new System.Windows.Forms.Padding(6);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(150, 44);
            this.BtnFechar.TabIndex = 4;
            this.BtnFechar.Text = "&Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // GroupDados
            // 
            this.GroupDados.Controls.Add(this.GridDados);
            this.GroupDados.Location = new System.Drawing.Point(24, 167);
            this.GroupDados.Margin = new System.Windows.Forms.Padding(6);
            this.GroupDados.Name = "GroupDados";
            this.GroupDados.Padding = new System.Windows.Forms.Padding(6);
            this.GroupDados.Size = new System.Drawing.Size(1520, 785);
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
            this.vNome,
            this.vCpf,
            this.vCelular,
            this.iId});
            this.GridDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridDados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridDados.Location = new System.Drawing.Point(6, 30);
            this.GridDados.Margin = new System.Windows.Forms.Padding(6);
            this.GridDados.Name = "GridDados";
            this.GridDados.RowHeadersVisible = false;
            this.GridDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridDados.Size = new System.Drawing.Size(1508, 749);
            this.GridDados.TabIndex = 0;
            // 
            // GroupFiltros
            // 
            this.GroupFiltros.Controls.Add(this.BtnConsultar);
            this.GroupFiltros.Controls.Add(this.TxtNome);
            this.GroupFiltros.Controls.Add(this.label1);
            this.GroupFiltros.Location = new System.Drawing.Point(24, 23);
            this.GroupFiltros.Margin = new System.Windows.Forms.Padding(6);
            this.GroupFiltros.Name = "GroupFiltros";
            this.GroupFiltros.Padding = new System.Windows.Forms.Padding(6);
            this.GroupFiltros.Size = new System.Drawing.Size(1520, 133);
            this.GroupFiltros.TabIndex = 0;
            this.GroupFiltros.TabStop = false;
            this.GroupFiltros.Text = "Filtros";
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(478, 65);
            this.BtnConsultar.Margin = new System.Windows.Forms.Padding(6);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(150, 44);
            this.BtnConsultar.TabIndex = 2;
            this.BtnConsultar.Text = "&Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(20, 69);
            this.TxtNome.Margin = new System.Windows.Forms.Padding(6);
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
            // vNome
            // 
            this.vNome.DataPropertyName = "vNome";
            this.vNome.HeaderText = "Nome";
            this.vNome.Name = "vNome";
            this.vNome.Width = 320;
            // 
            // vCpf
            // 
            this.vCpf.DataPropertyName = "vCpf";
            this.vCpf.HeaderText = "CPF";
            this.vCpf.Name = "vCpf";
            this.vCpf.Width = 200;
            // 
            // vCelular
            // 
            this.vCelular.DataPropertyName = "vCelular";
            this.vCelular.HeaderText = "Celular";
            this.vCelular.Name = "vCelular";
            this.vCelular.Width = 200;
            // 
            // iId
            // 
            this.iId.DataPropertyName = "iId";
            this.iId.HeaderText = "iId";
            this.iId.Name = "iId";
            this.iId.Visible = false;
            // 
            // FormGerenciamentoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 1029);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.GroupDados);
            this.Controls.Add(this.GroupFiltros);
            this.Margin = new System.Windows.Forms.Padding(12);
            this.Name = "FormGerenciamentoCliente";
            this.Text = "Gerenciamento de cliente";
            this.GroupDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridDados)).EndInit();
            this.GroupFiltros.ResumeLayout(false);
            this.GroupFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupFiltros;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.GroupBox GroupDados;
        private System.Windows.Forms.DataGridView GridDados;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn vCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn vCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn iId;
    }
}