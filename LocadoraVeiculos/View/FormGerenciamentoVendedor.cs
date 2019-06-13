using Util;
using System;
using System.Linq;
using System.Windows.Forms;
using Model;
using Controller;

namespace View
{
    public partial class FormGerenciamentoVendedor
    {
        public FormGerenciamentoVendedor()
        {
            InitializeComponent();
            GridDados.AutoGenerateColumns = false;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            FormManutencaoVendedor vFormManutencaoVendedor = new FormManutencaoVendedor(Enumeradores.EnumEstadoForm.CADASTRO, null);
            vFormManutencaoVendedor.ShowDialog(this);
            CarregarGrid();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioEntidade vUsuarioEntidade = new VendedorEntidade();
                vUsuarioEntidade.iId = Int32.Parse(GridDados.SelectedRows[0].Cells["iId"].Value.ToString());

                vUsuarioEntidade = new VendedorControlador().Consultar(vUsuarioEntidade).First();

                FormManutencaoVendedor vFormManutencaoVendedor = new FormManutencaoVendedor(Enumeradores.EnumEstadoForm.ALTERACAO, vUsuarioEntidade);
                vFormManutencaoVendedor.ShowDialog(this);

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
                VendedorEntidade vVendedorEntidade = new VendedorEntidade();
                vVendedorEntidade.vNome = TxtNome.Text;

                GridDados.DataSource = new VendedorControlador().Consultar(vVendedorEntidade);
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
