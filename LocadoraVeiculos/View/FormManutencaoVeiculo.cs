using System;
using Model;
using Controller;
using System.Windows.Forms;
using Util;

namespace View
{
    public partial class FormManutencaoVeiculo : FormPadrao
    {

        private Enumeradores.EnumEstadoForm aEstadoForm;
        private VeiculoEntidade aVeiculoEntidade;

        public FormManutencaoVeiculo(Enumeradores.EnumEstadoForm pEstadoForm, VeiculoEntidade pVeiculoEntidade)
        {
            InitializeComponent();

            aEstadoForm = pEstadoForm;

            if(aEstadoForm == Enumeradores.EnumEstadoForm.ALTERACAO)
            {
                aVeiculoEntidade = pVeiculoEntidade;
            }
        }

        private void FormManutencaoVeiculo_Load(object sender, EventArgs e)
        {
            try
            {
                //carrega o combo de montadoras
                MontadoraControlador vMontadoraControlador = new MontadoraControlador();
                CboMontadora.ValueMember = "iId";
                CboMontadora.DisplayMember = "vNome";
                CboMontadora.DataSource = vMontadoraControlador.Consultar(new MontadoraEntidade());

                if (aEstadoForm == Enumeradores.EnumEstadoForm.ALTERACAO)
                {
                    TxtModelo.Text = aVeiculoEntidade.vModelo;
                    CboMontadora.SelectedValue = aVeiculoEntidade.vMontadoraEntidade.iId;
                    TxtAnoFabricacao.Text = aVeiculoEntidade.iAnoFabricacao.ToString();
                    TxtCor.Text = aVeiculoEntidade.vCor;
                    TxtQtd.Text = aVeiculoEntidade.iQtd.ToString();

                    BtnCadastrar.Text = "&Alterar";
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message
                                , "Erro"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
            }

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                VeiculoEntidade vVeiculoEntidade = new VeiculoEntidade();

                vVeiculoEntidade.vModelo = TxtModelo.Text;
                vVeiculoEntidade.vMontadoraEntidade.iId = Int32.Parse(CboMontadora.SelectedValue.ToString());
                vVeiculoEntidade.iAnoFabricacao = Int32.Parse(TxtAnoFabricacao.Text);
                vVeiculoEntidade.vCor = TxtCor.Text;
                vVeiculoEntidade.iQtd = Int32.Parse(TxtQtd.Text);
                vVeiculoEntidade.iQtdDisponivel = vVeiculoEntidade.iQtd;

                VeiculoControlador vTbVeiculoControlador = new VeiculoControlador();

                if(aEstadoForm == Enumeradores.EnumEstadoForm.CADASTRO)
                {
                    vTbVeiculoControlador.Incluir(vVeiculoEntidade);
                }
                else
                {
                    vVeiculoEntidade.iId = aVeiculoEntidade.iId;
                    vTbVeiculoControlador.Alterar(vVeiculoEntidade);
                }

                MessageBox.Show("Veiculo salva com sucesso"
                               , "Informacao"
                               , MessageBoxButtons.OK
                               , MessageBoxIcon.Information);


                //fecha a tela
                this.Close();
            }
            catch(Exception ex)
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

        private void TxtQtdFabricas_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.PermitirApenasNumeroKeyPress(e);
        }

        private void TxtAnoFabricacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.PermitirApenasNumeroKeyPress(e);
        }
    }
}