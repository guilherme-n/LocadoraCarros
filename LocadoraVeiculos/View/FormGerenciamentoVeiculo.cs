using Util;
using System;
using System.Linq;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class FormGerenciamentoVeiculo
    {
        public FormGerenciamentoVeiculo()
        {
            InitializeComponent();
            GridDados.AutoGenerateColumns = false;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            FormManutencaoVeiculo vFormManutencaoVeiculo = new FormManutencaoVeiculo(Enumeradores.EnumEstadoForm.CADASTRO, null);
            vFormManutencaoVeiculo.ShowDialog(this);
            CarregarGrid();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                VeiculoEntidade vVeiculoEntidade = new VeiculoEntidade();
                vVeiculoEntidade.iId = Int32.Parse(GridDados.SelectedRows[0].Cells["iId"].Value.ToString());

                vVeiculoEntidade = VeiculoEntidade.Consultar(vVeiculoEntidade, false).First();

                FormManutencaoVeiculo vFormManutencaoVeiculo = new FormManutencaoVeiculo(Enumeradores.EnumEstadoForm.ALTERACAO, vVeiculoEntidade);
                vFormManutencaoVeiculo.ShowDialog(this);
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
                VeiculoEntidade vVeiculoEntidade = new VeiculoEntidade();
                vVeiculoEntidade.vModelo = TxtModelo.Text;

                GridDados.DataSource = VeiculoEntidade.Consultar(vVeiculoEntidade, false);
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