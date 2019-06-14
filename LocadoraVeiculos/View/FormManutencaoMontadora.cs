using System;
using Model;
using System.Windows.Forms;
using Util;

namespace View
{
    public partial class FormManutencaoMontadora : FormPadrao
    {

        private Enumeradores.EnumEstadoForm aEstadoForm;
        private MontadoraEntidade aMontadoraEntidade;

        public FormManutencaoMontadora(Enumeradores.EnumEstadoForm pEstadoForm, MontadoraEntidade pMontadoraEntidade)
        {
            InitializeComponent();

            aEstadoForm = pEstadoForm;

            if(aEstadoForm == Enumeradores.EnumEstadoForm.ALTERACAO)
            {
                aMontadoraEntidade = pMontadoraEntidade;
            }
        }

        private void FormManutencaoMontadora_Load(object sender, EventArgs e)
        {
            if(aEstadoForm == Enumeradores.EnumEstadoForm.ALTERACAO)
            {
                TxtNome.Text = aMontadoraEntidade.vNome;
                TxtCidadeFundacao.Text = aMontadoraEntidade.vCidadeFundacao;
                DtDataFundacao.Value = aMontadoraEntidade.dtDataFundacao;
                TxtFaturamento.Text = aMontadoraEntidade.dFaturamentoEmDolar.ToString();
                TxtLucroAnual.Text = aMontadoraEntidade.dLucroAnualEmDolar.ToString();
                TxtQtdFabricas.Text = aMontadoraEntidade.iQtdFabricas.ToString();

                BtnCadastrar.Text = "&Alterar";
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                MontadoraEntidade vMontadoraEntidade = new MontadoraEntidade();

                vMontadoraEntidade.vNome = TxtNome.Text;
                vMontadoraEntidade.vCidadeFundacao = TxtCidadeFundacao.Text;
                vMontadoraEntidade.dtDataFundacao = DtDataFundacao.Value;
                vMontadoraEntidade.dLucroAnualEmDolar =  Convert.ToDecimal(TxtLucroAnual.Text);
                vMontadoraEntidade.dFaturamentoEmDolar = Convert.ToDecimal(TxtFaturamento.Text);
                vMontadoraEntidade.iQtdFabricas = Convert.ToInt32(TxtQtdFabricas.Text);

                if (aEstadoForm == Enumeradores.EnumEstadoForm.ALTERACAO)
                {
                    vMontadoraEntidade.iId = aMontadoraEntidade.iId;
                }

                vMontadoraEntidade.Salvar();

                MessageBox.Show("Montadora salva com sucesso"
                               , "Informação"
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

        private void TxtQtdFabricas_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.PermitirApenasNumeroKeyPress(e);
        }

        private void TxtLucroAnual_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.PermitirApenasNumeroKeyPress(e);
        }

        private void TxtFaturamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.PermitirApenasNumeroKeyPress(e);
        }
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}