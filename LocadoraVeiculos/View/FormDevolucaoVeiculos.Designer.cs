namespace View
{
    partial class FormDevolucaoVeiculos : FormPadrao
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
            this.GroupDados = new System.Windows.Forms.GroupBox();
            this.GridDados = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.vModeloEPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDataInicioAluguel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDataEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Devolver = new System.Windows.Forms.DataGridViewImageColumn();
            this.iId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDados)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(527, 364);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 23);
            this.BtnFechar.TabIndex = 4;
            this.BtnFechar.Text = "&Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // GroupDados
            // 
            this.GroupDados.Controls.Add(this.GridDados);
            this.GroupDados.Location = new System.Drawing.Point(12, 12);
            this.GroupDados.Name = "GroupDados";
            this.GroupDados.Size = new System.Drawing.Size(593, 345);
            this.GroupDados.TabIndex = 0;
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
            this.vModeloEPlaca,
            this.vCliente,
            this.dtDataInicioAluguel,
            this.dtDataEntrega,
            this.Devolver,
            this.iId});
            this.GridDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridDados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridDados.Location = new System.Drawing.Point(3, 16);
            this.GridDados.Name = "GridDados";
            this.GridDados.RowHeadersVisible = false;
            this.GridDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridDados.Size = new System.Drawing.Size(587, 326);
            this.GridDados.TabIndex = 1;
            this.GridDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDados_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Devolver";
            this.dataGridViewImageColumn1.Image = global::LocadoraVeiculos.Properties.Resources.update;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 70;
            // 
            // vModeloEPlaca
            // 
            this.vModeloEPlaca.DataPropertyName = "vModeloEPlaca";
            this.vModeloEPlaca.HeaderText = "Veículo";
            this.vModeloEPlaca.Name = "vModeloEPlaca";
            this.vModeloEPlaca.Width = 120;
            // 
            // vCliente
            // 
            this.vCliente.DataPropertyName = "vCliente";
            this.vCliente.HeaderText = "Cliente";
            this.vCliente.Name = "vCliente";
            this.vCliente.Width = 140;
            // 
            // dtDataInicioAluguel
            // 
            this.dtDataInicioAluguel.DataPropertyName = "dtDataInicioAluguel";
            this.dtDataInicioAluguel.HeaderText = "Data da locação";
            this.dtDataInicioAluguel.Name = "dtDataInicioAluguel";
            this.dtDataInicioAluguel.Width = 120;
            // 
            // dtDataEntrega
            // 
            this.dtDataEntrega.DataPropertyName = "dtDataEntrega";
            this.dtDataEntrega.HeaderText = "Data de entrega";
            this.dtDataEntrega.Name = "dtDataEntrega";
            this.dtDataEntrega.Width = 120;
            // 
            // Devolver
            // 
            this.Devolver.HeaderText = "Devolver";
            this.Devolver.Image = global::LocadoraVeiculos.Properties.Resources.devolver;
            this.Devolver.Name = "Devolver";
            this.Devolver.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Devolver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Devolver.Width = 70;
            // 
            // iId
            // 
            this.iId.DataPropertyName = "iId";
            this.iId.HeaderText = "iId";
            this.iId.Name = "iId";
            this.iId.Visible = false;
            // 
            // FormDevolucaoVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 398);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.GroupDados);
            this.Name = "FormDevolucaoVeiculos";
            this.Text = "Devolução de veículos";
            this.Load += new System.EventHandler(this.FormDevolucaoVeiculos_Load);
            this.GroupDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupDados;
        private System.Windows.Forms.DataGridView GridDados;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vModeloEPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn vCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDataInicioAluguel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDataEntrega;
        private System.Windows.Forms.DataGridViewImageColumn Devolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn iId;
    }
}