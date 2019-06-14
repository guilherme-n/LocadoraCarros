using System;
using Model;
using System.Windows.Forms;
using Util;

namespace View
{
    public partial class FormManutencaoVendedor : FormPadrao
    {
        private Enumeradores.EnumEstadoForm aEstadoForm;
        private VendedorEntidade aVendedorEntidade;

        public FormManutencaoVendedor(Enumeradores.EnumEstadoForm pEstadoForm, UsuarioEntidade pUsuarioEntidade)
        {
            InitializeComponent();

            aEstadoForm = pEstadoForm;

            if (aEstadoForm == Enumeradores.EnumEstadoForm.ALTERACAO)
            {
                aVendedorEntidade = (VendedorEntidade)pUsuarioEntidade;

                if (aVendedorEntidade.dtDataDemissao > DateTime.MinValue)
                {
                    LblDataDemissao.Visible = true;
                }

            }
        }

        private void FormManutencaoVendedor_Load(object sender, EventArgs e)
        {
            if (aEstadoForm == Enumeradores.EnumEstadoForm.ALTERACAO)
            {
                TxtNome.Text = aVendedorEntidade.vNome;
                TxtCpf.Text = aVendedorEntidade.vCpf;
                TxtLogin.Text = aVendedorEntidade.vLogin;

                DtDataAdmissao.Value = aVendedorEntidade.dtDataAdmissao;
                TxtPercentualComissao.Text = aVendedorEntidade.iPercentualComissao.ToString();
                DtDataDemissao.Value = aVendedorEntidade.dtDataDemissao;
                RbtAtivo.Checked = aVendedorEntidade.bAtivo;
                RbtInativo.Checked = !aVendedorEntidade.bAtivo;

                TxtSenha.Enabled = false;
                TxtConfirmacaoSenha.Enabled = false;

                BtnCadastrar.Text = "&Alterar";
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                VendedorEntidade vVendedorEntidade = new VendedorEntidade();

                vVendedorEntidade.vNome = TxtNome.Text;
                vVendedorEntidade.vCpf = TxtCpf.Text;
                vVendedorEntidade.vLogin = TxtLogin.Text;
                vVendedorEntidade.dtDataAdmissao = DtDataAdmissao.Value;
                vVendedorEntidade.iPercentualComissao = int.Parse(TxtPercentualComissao.Text);
                vVendedorEntidade.dtDataDemissao = DtDataDemissao.Value;
                vVendedorEntidade.bAtivo = RbtAtivo.Checked;

                if (aEstadoForm == Enumeradores.EnumEstadoForm.CADASTRO)
                {
                    vVendedorEntidade.vSenha = TxtSenha.Text;
                }
                else if(aEstadoForm == Enumeradores.EnumEstadoForm.ALTERACAO)
                {
                    vVendedorEntidade.iId = aVendedorEntidade.iId;
                }

                vVendedorEntidade.Salvar();

                MessageBox.Show("Vendedor salvo com sucesso"
                               , "Informacao"
                               , MessageBoxButtons.OK
                               , MessageBoxIcon.Information);


                //fecha a tela
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao " + ex.Message
                                , "Erro"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
            }
        }

        private void TxtPercentualComissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.PermitirApenasNumeroKeyPress(e);
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}