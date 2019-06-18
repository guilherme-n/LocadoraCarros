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

namespace View
{
    public partial class FormReservaVeiculo : FormPadrao
    {
        public FormReservaVeiculo()
        {
            InitializeComponent();
            GridDados.AutoGenerateColumns = false;
        }

        private void FormReservaVeiculo_Load(object sender, EventArgs e)
        {
            GridDados.DataSource = VeiculoEntidade.Consultar(false);
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                VeiculoEntidade vVeiculoEntidade = new VeiculoEntidade();

                switch (GridDados.Columns[e.ColumnIndex].Name)
                {
                    case "Reservar":
                        if(GridDados.Rows[e.RowIndex].Cells["vEstado"].Value.Equals("Reservado"))
                        {
                            MessageBox.Show("Veículo já se encontra reservado"
                                            , "Aviso"
                                            , MessageBoxButtons.OK
                                            , MessageBoxIcon.Warning);
                            return;
                        }

                        vVeiculoEntidade.iId = Int32.Parse(GridDados.Rows[e.RowIndex].Cells["iId"].Value.ToString());
                        vVeiculoEntidade.AlterarEstado(Util.Enumeradores.EnumEstadoVeiculo.RESERVADO);

                        MessageBox.Show("Veículo reservado com sucesso"
                                        , "Informação"
                                        , MessageBoxButtons.OK
                                        , MessageBoxIcon.Information);

                        GridDados.DataSource = VeiculoEntidade.Consultar(false);
                        break;

                    case "CancelarReserva":
                        if (GridDados.Rows[e.RowIndex].Cells["vEstado"].Value.Equals("Disponivel"))
                        {
                            MessageBox.Show("Cancelamento já foi realizado"
                                            , "Aviso"
                                            , MessageBoxButtons.OK
                                            , MessageBoxIcon.Warning);
                            return;
                        }

                        vVeiculoEntidade.iId = Int32.Parse(GridDados.Rows[e.RowIndex].Cells["iId"].Value.ToString());
                        vVeiculoEntidade.AlterarEstado(Util.Enumeradores.EnumEstadoVeiculo.DISPONIVEL);
                        GridDados.Rows[e.RowIndex].Cells["vEstado"].Value = "Disponivel";

                        MessageBox.Show("Cancelamento de reserva efetuado com sucesso."
                                        , "Informação"
                                        , MessageBoxButtons.OK
                                        , MessageBoxIcon.Information);

                        GridDados.DataSource = VeiculoEntidade.Consultar(false);
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao " + ex.Message
                                , "Erro"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
            }           
        }
    }
}