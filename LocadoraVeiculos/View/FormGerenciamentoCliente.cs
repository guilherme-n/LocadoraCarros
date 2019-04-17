using LocadoraVeiculos.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;

namespace LocadoraVeiculos.View
{
    public partial class FormGerenciamentoCliente
    {
        public FormGerenciamentoCliente()
        {
            InitializeComponent();
            GridDados.AutoGenerateColumns = false;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            FormManutencaoCliente vFormManutencaoCliente = new FormManutencaoCliente(Enumeradores.EnumEstadoForm.CADASTRO, null);
            vFormManutencaoCliente.ShowDialog(this);
            CarregarGrid();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteEntidade vClienteEntidade = new ClienteEntidade();
                vClienteEntidade.iId = Int32.Parse(GridDados.SelectedRows[0].Cells["iId"].Value.ToString());

                vClienteEntidade = new ClienteControlador().Consultar(vClienteEntidade).First();

                FormManutencaoCliente vFormManutencaoCliente = new FormManutencaoCliente(Enumeradores.EnumEstadoForm.ALTERACAO, vClienteEntidade);
                vFormManutencaoCliente.ShowDialog(this);

                CarregarGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao " + ex.Message
                                , "Erro"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao " + ex.Message
                                , "Erro"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
            }
        }

        private void CarregarGrid()
        {
            try
            {
                ClienteEntidade vClienteEntidade = new ClienteEntidade();
                vClienteEntidade.vNome = TxtNome.Text;

                GridDados.DataSource = new ClienteControlador().Consultar(vClienteEntidade);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao " + ex.Message
                                , "Erro"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
