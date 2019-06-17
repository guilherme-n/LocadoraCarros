using System;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class FormDevolucaoVeiculos : FormPadrao
    {
        public FormDevolucaoVeiculos()
        {
            InitializeComponent();
            GridDados.AutoGenerateColumns = false;
        }

        private void FormDevolucaoVeiculos_Load(object sender, EventArgs e)
        {
            try
            {
                GridDados.DataSource = AluguelEntidade.Consultar(true);
            } catch(Exception ex)
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

        private void GridDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GridDados.Columns[e.ColumnIndex].Name.Equals("Devolver"))
                {
                    DialogResult vResposta = MessageBox.Show("Deseja realmente devolver este veículo?"
                                                                , "Pergunta"
                                                                , MessageBoxButtons.YesNo
                                                                , MessageBoxIcon.Question
                                                                , MessageBoxDefaultButton.Button2);

                    if (vResposta == DialogResult.No)
                    {
                        return;
                    }

                    AluguelEntidade vAluguelEntidade = new AluguelEntidade();
                    vAluguelEntidade.iId = Int32.Parse(GridDados.Rows[e.RowIndex].Cells["iId"].Value.ToString());
                    vAluguelEntidade.DevolverVeiculo();

                    MessageBox.Show("Veículo devolvido com sucesso."
                                    , "Informação"
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Information);

                    GridDados.DataSource = AluguelEntidade.Consultar(true);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao " + ex.Message
                                , "Erro"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
            }
        }
    }
}