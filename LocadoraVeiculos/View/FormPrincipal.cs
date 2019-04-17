using System;
using System.Windows.Forms;

namespace LocadoraVeiculos.View
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void MontadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGerenciamentoMontadora vFormGerenciamentoMontadora = new FormGerenciamentoMontadora();
            vFormGerenciamentoMontadora.ShowDialog(this);
        }

        private void PaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGerenciamentoPais vFormGerenciamentoPais = new FormGerenciamentoPais();
            vFormGerenciamentoPais.ShowDialog(this);
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGerenciamentoVendedor vFormGerenciamentoVendedor = new FormGerenciamentoVendedor();
            vFormGerenciamentoVendedor.ShowDialog(this);
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGerenciamentoCliente vFormGerenciamentoCliente = new FormGerenciamentoCliente();
            vFormGerenciamentoCliente.ShowDialog(this);
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
