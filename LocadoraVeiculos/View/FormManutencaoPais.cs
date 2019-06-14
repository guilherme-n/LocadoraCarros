using System;
using Model;
using System.Windows.Forms;
using Util;

namespace View
{
    public partial class FormManutencaoPais : FormPadrao
    {

        private Enumeradores.EnumEstadoForm aEstadoForm;
        private PaisEntidade aPaisEntidade;

        public FormManutencaoPais(Enumeradores.EnumEstadoForm pEstadoForm, PaisEntidade pPaisEntidade)
        {
            InitializeComponent();

            aEstadoForm = pEstadoForm;

            if(aEstadoForm == Enumeradores.EnumEstadoForm.ALTERACAO)
            {
                aPaisEntidade = pPaisEntidade;
            }
        }

        private void FormManutencaoPais_Load(object sender, EventArgs e)
        {
            if(aEstadoForm == Enumeradores.EnumEstadoForm.ALTERACAO)
            {
                TxtNome.Text = aPaisEntidade.vNome;
                TxtIdiomaPrincipal.Text = aPaisEntidade.vIdiomaPrincipal;
                TxtAnoFundacao.Text = aPaisEntidade.iAnoFundacao.ToString();
                TxtPib.Text = aPaisEntidade.dPibEmDolar.ToString();
                TxtQtdHabitantes.Text = aPaisEntidade.iQtdHabitantes.ToString();

                BtnCadastrar.Text = "&Alterar";
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                PaisEntidade vPaisEntidade = new PaisEntidade();

                vPaisEntidade.vNome = TxtNome.Text;
                vPaisEntidade.vIdiomaPrincipal = TxtIdiomaPrincipal.Text;
                vPaisEntidade.iAnoFundacao = Convert.ToInt16(TxtAnoFundacao.Text);
                vPaisEntidade.dPibEmDolar =  Convert.ToDecimal(TxtPib.Text.Replace(" ",""));
                vPaisEntidade.iQtdHabitantes = Convert.ToInt64(TxtQtdHabitantes.Text.Replace(" ",""));

                if(aEstadoForm == Enumeradores.EnumEstadoForm.ALTERACAO)
                {
                    vPaisEntidade.iId = aPaisEntidade.iId;                    
                }

                vPaisEntidade.Salvar();

                MessageBox.Show("Pais salvo com sucesso"
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

        private void TxtAnoFundacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.PermitirApenasNumeroKeyPress(e);
        }

        private void TxtQtdHabitantes_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.PermitirApenasNumeroKeyPress(e);
        }
    }
}