using System;
using Model;
using Controller;
using System.Windows.Forms;
using LocadoraVeiculos.Util;

namespace LocadoraVeiculos.View
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

        private void FormManutencaoVendedor_Load(object sender, EventArgs e)
        {
            if (aEstadoForm == Enumeradores.EnumEstadoForm.ALTERACAO)
            {
                TxtNome.Text = aVendedorEntidade.vNome;
                TxtCpf.Text = aVendedorEntidade.vCpf;
                TxtLogin.Text = aVendedorEntidade.vLogin;

                TxtSenha.Text = aVendedorEntidade.vSenha;
                DtDataAdmissao.Value = aVendedorEntidade.dtDataAdmissao;
                TxtPercentualComissao.Text = aVendedorEntidade.iPercentualComissao.ToString();
                DtDataDemissao.Value = aVendedorEntidade.dtDataDemissao;
                RbtAtivo.Checked = aVendedorEntidade.bAtivo;
                RbtInativo.Checked = !aVendedorEntidade.bAtivo;

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
                vVendedorEntidade.vSenha = TxtSenha.Text;
                vVendedorEntidade.dtDataAdmissao = DtDataAdmissao.Value;
                vVendedorEntidade.iPercentualComissao = int.Parse(TxtPercentualComissao.Text);
                vVendedorEntidade.dtDataDemissao = DtDataDemissao.Value;
                vVendedorEntidade.bAtivo = RbtAtivo.Checked;

                VendedorControlador vTbVendedorControlador = new VendedorControlador();

                if (aEstadoForm == Enumeradores.EnumEstadoForm.CADASTRO)
                {
                    vTbVendedorControlador.Incluir(vVendedorEntidade);
                }
                else
                {
                    vVendedorEntidade.iId = aVendedorEntidade.iId;
                    vTbVendedorControlador.Alterar(vVendedorEntidade);
                }

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