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

        public FormManutencaoVendedor(Enumeradores.EnumEstadoForm pEstadoForm, VendedorEntidade pVendedorEntidade)
        {
            InitializeComponent();

            aEstadoForm = pEstadoForm;

            if (aEstadoForm == Enumeradores.EnumEstadoForm.ALTERACAO)
            {
                aVendedorEntidade = pVendedorEntidade;

                if (aVendedorEntidade.dtDataDemissao > DateTime.MinValue)
                {
                    LblDataDemissao.Visible = true;
                }

            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (!validarCamposObrigatorios())
                {
                    return;
                }

                VendedorEntidade vVendedorEntidade = new VendedorEntidade();

                vVendedorEntidade.vNome = TxtNome.Text;
                vVendedorEntidade.vCpf = TxtCpf.Text;
                vVendedorEntidade.vLogin = TxtLogin.Text;
                vVendedorEntidade.dtDataAdmissao = DtDataAdmissao.Value;
                vVendedorEntidade.iPercentualComissao = int.Parse(TxtPercentualComissao.Text);
                vVendedorEntidade.dtDataDemissao = DtDataDemissao.Value;
                vVendedorEntidade.bAtivo = RbtAtivo.Checked;
                vVendedorEntidade.dSalario = Decimal.Parse(TxtSalario.Text);

                if (aEstadoForm == Enumeradores.EnumEstadoForm.CADASTRO)
                {
                    vVendedorEntidade.vSenha = TxtSenha.Text;
                }
                else if(aEstadoForm == Enumeradores.EnumEstadoForm.ALTERACAO)
                {
                    vVendedorEntidade.iId = aVendedorEntidade.iId;
                    vVendedorEntidade.vSenha = aVendedorEntidade.vSenha;
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

        private void FormManutencaoVendedor_Load(object sender, EventArgs e)
        {
            if (aEstadoForm == Enumeradores.EnumEstadoForm.ALTERACAO)
            {
                TxtNome.Text = aVendedorEntidade.vNome;
                TxtCpf.Text = aVendedorEntidade.vCpf;
                TxtLogin.Text = aVendedorEntidade.vLogin;

                DtDataAdmissao.Value = aVendedorEntidade.dtDataAdmissao;
                TxtPercentualComissao.Text = aVendedorEntidade.iPercentualComissao.ToString();
                TxtSalario.Text = aVendedorEntidade.dSalario.ToString();
                DtDataDemissao.Value = aVendedorEntidade.dtDataDemissao;
                RbtAtivo.Checked = aVendedorEntidade.bAtivo;
                RbtInativo.Checked = !aVendedorEntidade.bAtivo;

                TxtSenha.Enabled = false;
                TxtConfirmacaoSenha.Enabled = false;

                BtnCadastrar.Text = "&Alterar";
            }
        }

        private bool validarCamposObrigatorios()
        {
            if (string.IsNullOrWhiteSpace(TxtNome.Text))
            {
                MessageBox.Show("Favor informar o nome"
                                , "Aviso"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Warning);
                TxtNome.Focus();
                return false;
            }

            if (!TxtCpf.MaskCompleted)
            {
                MessageBox.Show("Favor informar o CPF"
                                , "Aviso"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Warning);
                TxtCpf.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtLogin.Text))
            {
                MessageBox.Show("Favor informar o login"
                                , "Aviso"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Warning);
                TxtLogin.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtSenha.Text))
            {
                MessageBox.Show("Favor informar a senha"
                                , "Aviso"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Warning);
                TxtSenha.Focus();
                return false;
            }

            if (!TxtSenha.Text.Equals(TxtConfirmacaoSenha.Text))
            {
                MessageBox.Show("As senhas não são iguais"
                                , "Aviso"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Warning);
                TxtSenha.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtPercentualComissao.Text))
            {
                MessageBox.Show("Favor informar o percentual de comissão"
                                , "Aviso"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Warning);
                TxtPercentualComissao.Focus();
                return false;
            }

            return true;
        }

        private void TxtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.PermitirApenasNumeroKeyPress(e);
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}