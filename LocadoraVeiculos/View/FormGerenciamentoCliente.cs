using Util;
using System;
using System.Linq;
using System.Windows.Forms;
using Model;

namespace View
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

                GridDados.DataSource = ClienteEntidade.Consultar(vClienteEntidade);
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

        private void GridDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (GridDados.Columns[e.ColumnIndex].Name)
            {
                case "Alterar":
                    try
                    {
                        ClienteEntidade vClienteEntidade = new ClienteEntidade();
                        vClienteEntidade.iId = Int32.Parse(GridDados.SelectedRows[0].Cells["iId"].Value.ToString());

                        vClienteEntidade = ClienteEntidade.Consultar(vClienteEntidade).First();

                        FormManutencaoCliente vFormManutencaoCliente = new FormManutencaoCliente(Enumeradores.EnumEstadoForm.ALTERACAO, vClienteEntidade);
                        vFormManutencaoCliente.ShowDialog(this);

                        CarregarGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao " + ex.Message
                                        , "Erro"
                                        , MessageBoxButtons.OK
                                        , MessageBoxIcon.Error);
                    }
                    break;

                case "Excluir":
                    try
                    {
                        DialogResult vResposta = MessageBox.Show("Deseja realmente excluir este cliente?"
                                                                , "Pergunta"
                                                                , MessageBoxButtons.YesNo
                                                                , MessageBoxIcon.Question
                                                                , MessageBoxDefaultButton.Button2);

                        if (vResposta == DialogResult.No)
                        {
                            return;
                        }

                        ClienteEntidade vClienteEntidade = new ClienteEntidade();
                        vClienteEntidade.iId = Int32.Parse(GridDados.SelectedRows[0].Cells["iId"].Value.ToString());
                        vClienteEntidade = ClienteEntidade.Consultar().First();
                        vClienteEntidade.Excluir();

                        MessageBox.Show("Cliente excluído com sucesso."
                                        , "Informação"
                                        , MessageBoxButtons.OK
                                        , MessageBoxIcon.Information);

                        CarregarGrid();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao " + ex.Message
                                        , "Erro"
                                        , MessageBoxButtons.OK
                                        , MessageBoxIcon.Error);
                    }

                    break;
            }
        }
    }
}