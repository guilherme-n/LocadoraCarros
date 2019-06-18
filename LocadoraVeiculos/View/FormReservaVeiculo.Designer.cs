namespace View
{
    partial class FormReservaVeiculo : FormPadrao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.GroupDados = new System.Windows.Forms.GroupBox();
            this.GridDados = new System.Windows.Forms.DataGridView();
            this.vModeloEPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dValorLocacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reservar = new System.Windows.Forms.DataGridViewImageColumn();
            this.CancelarReserva = new System.Windows.Forms.DataGridViewImageColumn();
            this.iId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDados)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(471, 371);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 23);
            this.BtnFechar.TabIndex = 6;
            this.BtnFechar.Text = "&Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // GroupDados
            // 
            this.GroupDados.Controls.Add(this.GridDados);
            this.GroupDados.Location = new System.Drawing.Point(12, 12);
            this.GroupDados.Name = "GroupDados";
            this.GroupDados.Size = new System.Drawing.Size(534, 345);
            this.GroupDados.TabIndex = 5;
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
            this.vEstado,
            this.dValorLocacao,
            this.Reservar,
            this.CancelarReserva,
            this.iId});
            this.GridDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridDados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridDados.Location = new System.Drawing.Point(3, 16);
            this.GridDados.Name = "GridDados";
            this.GridDados.RowHeadersVisible = false;
            this.GridDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridDados.Size = new System.Drawing.Size(528, 326);
            this.GridDados.TabIndex = 1;
            this.GridDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDados_CellContentClick);
            // 
            // vModeloEPlaca
            // 
            this.vModeloEPlaca.DataPropertyName = "vModeloEPlaca";
            this.vModeloEPlaca.HeaderText = "Veículo";
            this.vModeloEPlaca.Name = "vModeloEPlaca";
            this.vModeloEPlaca.Width = 120;
            // 
            // vEstado
            // 
            this.vEstado.DataPropertyName = "vEstado";
            this.vEstado.HeaderText = "Estado";
            this.vEstado.Name = "vEstado";
            // 
            // dValorLocacao
            // 
            this.dValorLocacao.DataPropertyName = "dValorLocacao";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dValorLocacao.DefaultCellStyle = dataGridViewCellStyle1;
            this.dValorLocacao.HeaderText = "Valor da diária";
            this.dValorLocacao.Name = "dValorLocacao";
            // 
            // Reservar
            // 
            this.Reservar.HeaderText = "Reservar";
            this.Reservar.Image = global::LocadoraVeiculos.Properties.Resources.reservar;
            this.Reservar.Name = "Reservar";
            this.Reservar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Reservar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Reservar.Width = 70;
            // 
            // CancelarReserva
            // 
            this.CancelarReserva.HeaderText = "Cancelar reserva";
            this.CancelarReserva.Image = global::LocadoraVeiculos.Properties.Resources.cancelar_reserva;
            this.CancelarReserva.Name = "CancelarReserva";
            this.CancelarReserva.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CancelarReserva.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CancelarReserva.Width = 120;
            // 
            // iId
            // 
            this.iId.DataPropertyName = "iId";
            this.iId.HeaderText = "iId";
            this.iId.Name = "iId";
            this.iId.Visible = false;
            // 
            // FormReservaVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 406);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.GroupDados);
            this.Name = "FormReservaVeiculo";
            this.Text = "Reserva de veículo";
            this.Load += new System.EventHandler(this.FormReservaVeiculo_Load);
            this.GroupDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.GroupBox GroupDados;
        private System.Windows.Forms.DataGridView GridDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn vModeloEPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn vEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dValorLocacao;
        private System.Windows.Forms.DataGridViewImageColumn Reservar;
        private System.Windows.Forms.DataGridViewImageColumn CancelarReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn iId;
    }
}