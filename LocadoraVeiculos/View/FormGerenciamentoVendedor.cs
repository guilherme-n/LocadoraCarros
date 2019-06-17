﻿using Util;
using System;
using System.Windows.Forms;
using Model;

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

                GridDados.DataSource = VendedorEntidade.Consultar(vVendedorEntidade);
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
                        VendedorEntidade vVendedorEntidade = new VendedorEntidade();
                        vVendedorEntidade.iId = Int32.Parse(GridDados.Rows[e.RowIndex].Cells["iId"].Value.ToString());

                        vVendedorEntidade.Carregar();

                        FormManutencaoVendedor vFormManutencaoVendedor = new FormManutencaoVendedor(Enumeradores.EnumEstadoForm.ALTERACAO, vVendedorEntidade);
                        vFormManutencaoVendedor.ShowDialog(this);

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
                        DialogResult vResposta = MessageBox.Show("Deseja realmente excluir este vendedor?"
                                                                , "Pergunta"
                                                                , MessageBoxButtons.YesNo
                                                                , MessageBoxIcon.Question
                                                                , MessageBoxDefaultButton.Button2);

                        if(vResposta == DialogResult.No)
                        {
                            return;
                        }

                        VendedorEntidade vVendedorEntidade = new VendedorEntidade();
                        vVendedorEntidade.iId = Int32.Parse(GridDados.Rows[e.RowIndex].Cells["iId"].Value.ToString());
                        vVendedorEntidade.Excluir();

                        MessageBox.Show("Vendedor excluído com sucesso."
                                        , "Informação"
                                        , MessageBoxButtons.OK
                                        , MessageBoxIcon.Information);

                        CarregarGrid();

                    } catch (Exception ex)
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