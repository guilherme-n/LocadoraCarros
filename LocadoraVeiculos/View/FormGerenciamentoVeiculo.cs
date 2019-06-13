using Util;
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

                vVeiculoEntidade = new VeiculoControlador().Consultar(vVeiculoEntidade, false).First();

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

                GridDados.DataSource = new VeiculoControlador().Consultar(vVeiculoEntidade, false);
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