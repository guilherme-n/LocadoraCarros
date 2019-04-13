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

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

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
    }
}
