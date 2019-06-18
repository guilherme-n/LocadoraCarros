using System;
using System.Data;
using System.Windows.Forms;
using LocadoraVeiculos.Relatorios;
using Model;
using Util;

namespace View
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

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            FormLogin vFormLogin = new FormLogin();
            vFormLogin.ShowDialog(this);

            if(RecursosGlobais.VendedorLogado != null)
            {
                this.Text = "Locadora de Veiculos - Vendedor " + RecursosGlobais.VendedorLogado.vNome;
            }
        }

        private void veículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGerenciamentoVeiculo vFormGerenciamentoVeiculo = new FormGerenciamentoVeiculo();
            vFormGerenciamentoVeiculo.ShowDialog(this);
        }

        private void locacaoDeVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLocacaoVeiculos vFormLocacaoVeiculos = new FormLocacaoVeiculos();
            vFormLocacaoVeiculos.ShowDialog();
        }

        private void TrocarDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin vFormLogin = new FormLogin();
            vFormLogin.ShowDialog(this);

            if (RecursosGlobais.VendedorLogado != null)
            {
                this.Text = "Locadora de Veículos - Vendedor " + RecursosGlobais.VendedorLogado.vNome;
            }
        }

        private void alteracaoDeSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlteracaoSenha vFormAlteracaoSenha = new FormAlteracaoSenha();
            vFormAlteracaoSenha.ShowDialog(this);
        }

        private void devolucaoDeVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDevolucaoVeiculos vFormDevolucaoVeiculos = new FormDevolucaoVeiculos();
            vFormDevolucaoVeiculos.ShowDialog(this);
        }

        private void versaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSobre vFormSobre = new FormSobre();
            vFormSobre.ShowDialog(this);
        }

        private void reservaDeVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReservaVeiculo vFormReservaVeiculo = new FormReservaVeiculo();
            vFormReservaVeiculo.ShowDialog(this);
        }

        private void carrosAlugadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                RelatorioCarrosAlugados vRelatorioCarrosAlugados = new RelatorioCarrosAlugados();
                DataSet vDataSet = new DataSet();

                vDataSet = AluguelEntidade.RelatorioVeiculosAlugados();

                vRelatorioCarrosAlugados.SetDataSource(vDataSet.Tables[0]);

                PrintDialog vPrintDialog = new PrintDialog();
                vPrintDialog.UseEXDialog = true;
                if (vPrintDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }

                vRelatorioCarrosAlugados.PrintToPrinter(vPrintDialog.PrinterSettings.Copies
                                                         , vPrintDialog.PrinterSettings.Collate
                                                         , vPrintDialog.PrinterSettings.FromPage
                                                         , vPrintDialog.PrinterSettings.ToPage);

                MessageBox.Show("Relatório impresso com sucesso"
                                , "Informação"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);

            } catch(Exception ex)
            {
                MessageBox.Show("Erro ao logar no sistema"
                                , "Erro"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
