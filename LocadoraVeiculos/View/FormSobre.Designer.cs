namespace View
{
    partial class FormSobre : FormPadrao
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
            this.BtnOK = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.LabelProductName = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(296, 138);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 5;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.LabelVersion);
            this.GroupBox1.Controls.Add(this.LabelProductName);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(359, 100);
            this.GroupBox1.TabIndex = 6;
            this.GroupBox1.TabStop = false;
            // 
            // LabelVersion
            // 
            this.LabelVersion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LabelVersion.ForeColor = System.Drawing.Color.Maroon;
            this.LabelVersion.Location = new System.Drawing.Point(9, 67);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(344, 19);
            this.LabelVersion.TabIndex = 1;
            this.LabelVersion.Text = "Versão";
            this.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelProductName
            // 
            this.LabelProductName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProductName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabelProductName.Location = new System.Drawing.Point(6, 11);
            this.LabelProductName.Name = "LabelProductName";
            this.LabelProductName.Size = new System.Drawing.Size(347, 43);
            this.LabelProductName.TabIndex = 0;
            this.LabelProductName.Text = "Locadora de Veículos";
            this.LabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 173);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.BtnOK);
            this.Name = "FormSobre";
            this.Text = "Sobre o Locadora de veículos";
            this.Load += new System.EventHandler(this.FormVersao_Load);
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label LabelVersion;
        internal System.Windows.Forms.Label LabelProductName;
    }
}