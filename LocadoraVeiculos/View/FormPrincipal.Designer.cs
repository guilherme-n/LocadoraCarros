﻿namespace View
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.servicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locacaoDeVeiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.montadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alteracaoDeSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucaoDeVeiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaDeVeiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelamentoDeReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrosAlugadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reciboDeRecebimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.servicosToolStripMenuItem,
            this.cadastrosToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.perfilToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1600, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // servicosToolStripMenuItem
            // 
            this.servicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locacaoDeVeiculoToolStripMenuItem,
            this.devolucaoDeVeiculoToolStripMenuItem,
            this.reservaDeVeiculoToolStripMenuItem,
            this.cancelamentoDeReservaToolStripMenuItem,
            this.reciboDeRecebimentoToolStripMenuItem});
            this.servicosToolStripMenuItem.Name = "servicosToolStripMenuItem";
            this.servicosToolStripMenuItem.Size = new System.Drawing.Size(114, 36);
            this.servicosToolStripMenuItem.Text = "&Serviços";
            // 
            // locacaoDeVeiculoToolStripMenuItem
            // 
            this.locacaoDeVeiculoToolStripMenuItem.Name = "locacaoDeVeiculoToolStripMenuItem";
            this.locacaoDeVeiculoToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.locacaoDeVeiculoToolStripMenuItem.Text = "&Locação de veículo";
            this.locacaoDeVeiculoToolStripMenuItem.Click += new System.EventHandler(this.locacaoDeVeiculoToolStripMenuItem_Click);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.montadoraToolStripMenuItem,
            this.paisToolStripMenuItem,
            this.vendedorToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.veículoToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(130, 38);
            this.cadastrosToolStripMenuItem.Text = "&Cadastros";
            // 
            // montadoraToolStripMenuItem
            // 
            this.montadoraToolStripMenuItem.Name = "montadoraToolStripMenuItem";
            this.montadoraToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.montadoraToolStripMenuItem.Text = "&Montadora";
            this.montadoraToolStripMenuItem.Click += new System.EventHandler(this.MontadoraToolStripMenuItem_Click);
            // 
            // paisToolStripMenuItem
            // 
            this.paisToolStripMenuItem.Name = "paisToolStripMenuItem";
            this.paisToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.paisToolStripMenuItem.Text = "&País";
            this.paisToolStripMenuItem.Click += new System.EventHandler(this.PaisToolStripMenuItem_Click);
            // 
            // vendedorToolStripMenuItem
            // 
            this.vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            this.vendedorToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.vendedorToolStripMenuItem.Text = "&Vendedor";
            this.vendedorToolStripMenuItem.Click += new System.EventHandler(this.vendedorToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.clienteToolStripMenuItem.Text = "&Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // veículoToolStripMenuItem
            // 
            this.veículoToolStripMenuItem.Name = "veículoToolStripMenuItem";
            this.veículoToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.veículoToolStripMenuItem.Text = "&Veículo";
            this.veículoToolStripMenuItem.Click += new System.EventHandler(this.veículoToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versaoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(89, 38);
            this.sobreToolStripMenuItem.Text = "&Sobre";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // versaoToolStripMenuItem
            // 
            this.versaoToolStripMenuItem.Name = "versaoToolStripMenuItem";
            this.versaoToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.versaoToolStripMenuItem.Text = "Versao";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alteracaoDeSenhaToolStripMenuItem,
            this.trocarDeUsuarioToolStripMenuItem});
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(80, 38);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // alteracaoDeSenhaToolStripMenuItem
            // 
            this.alteracaoDeSenhaToolStripMenuItem.Name = "alteracaoDeSenhaToolStripMenuItem";
            this.alteracaoDeSenhaToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.alteracaoDeSenhaToolStripMenuItem.Text = "Alteracao de senha";
            // 
            // trocarDeUsuarioToolStripMenuItem
            // 
            this.trocarDeUsuarioToolStripMenuItem.Name = "trocarDeUsuarioToolStripMenuItem";
            this.trocarDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.trocarDeUsuarioToolStripMenuItem.Text = "Trocar de usuario";
            this.trocarDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.TrocarDeUsuarioToolStripMenuItem_Click);
            // 
            // devolucaoDeVeiculoToolStripMenuItem
            // 
            this.devolucaoDeVeiculoToolStripMenuItem.Name = "devolucaoDeVeiculoToolStripMenuItem";
            this.devolucaoDeVeiculoToolStripMenuItem.Size = new System.Drawing.Size(344, 38);
            this.devolucaoDeVeiculoToolStripMenuItem.Text = "Devolucao de veiculo";
            // 
            // reservaDeVeiculoToolStripMenuItem
            // 
            this.reservaDeVeiculoToolStripMenuItem.Name = "reservaDeVeiculoToolStripMenuItem";
            this.reservaDeVeiculoToolStripMenuItem.Size = new System.Drawing.Size(384, 38);
            this.reservaDeVeiculoToolStripMenuItem.Text = "Reserva de veiculo";
            // 
            // cancelamentoDeReservaToolStripMenuItem
            // 
            this.cancelamentoDeReservaToolStripMenuItem.Name = "cancelamentoDeReservaToolStripMenuItem";
            this.cancelamentoDeReservaToolStripMenuItem.Size = new System.Drawing.Size(384, 38);
            this.cancelamentoDeReservaToolStripMenuItem.Text = "Cancelamento de reserva";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carrosAlugadosToolStripMenuItem,
            this.reservasToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(131, 36);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // carrosAlugadosToolStripMenuItem
            // 
            this.carrosAlugadosToolStripMenuItem.Name = "carrosAlugadosToolStripMenuItem";
            this.carrosAlugadosToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.carrosAlugadosToolStripMenuItem.Text = "Carros alugados";
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.reservasToolStripMenuItem.Text = "Reservas";
            // 
            // reciboDeRecebimentoToolStripMenuItem
            // 
            this.reciboDeRecebimentoToolStripMenuItem.Name = "reciboDeRecebimentoToolStripMenuItem";
            this.reciboDeRecebimentoToolStripMenuItem.Size = new System.Drawing.Size(384, 38);
            this.reciboDeRecebimentoToolStripMenuItem.Text = "Recibo de recebimento";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locadora de Veiculos";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem servicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locacaoDeVeiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem montadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alteracaoDeSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trocarDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucaoDeVeiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaDeVeiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelamentoDeReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reciboDeRecebimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrosAlugadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
    }
}

