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
    public partial class FormGerenciamentoMontadora 
    {
        public FormGerenciamentoMontadora()
        {
            InitializeComponent();
            GridDados.AutoGenerateColumns = false;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            FormManutencaoMontadora vFormManutencaoMontadora = new FormManutencaoMontadora(Enumeradores.EnumEstadoForm.CADASTRO, null);
            vFormManutencaoMontadora.ShowDialog(this);
            CarregarGrid();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                MontadoraEntidade vMontadoraEntidade = new MontadoraEntidade();
                vMontadoraEntidade.iId = Int32.Parse(GridDados.SelectedRows[0].Cells["iId"].Value.ToString());

                vMontadoraEntidade = new MontadoraControlador().Consultar(vMontadoraEntidade).First();

                FormManutencaoMontadora vFormManutencaoMontadora = new FormManutencaoMontadora(Enumeradores.EnumEstadoForm.ALTERACAO, vMontadoraEntidade);
                vFormManutencaoMontadora.ShowDialog(this);
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
                MontadoraEntidade vMontadoraEntidade = new MontadoraEntidade();
                vMontadoraEntidade.vNome = TxtNome.Text;

                GridDados.DataSource = new MontadoraControlador().Consultar(vMontadoraEntidade);
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