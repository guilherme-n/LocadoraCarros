using System;
using Model;
using Controller;
using System.Windows.Forms;
using Util;

namespace View
{
    public partial class FormManutencaoCliente : FormPadrao
    {

        private Enumeradores.EnumEstadoForm aEstadoForm;
        private ClienteEntidade aClienteEntidade;

        public FormManutencaoCliente(Enumeradores.EnumEstadoForm pEstadoForm, ClienteEntidade pClienteEntidade)
        {
            InitializeComponent();

            aEstadoForm = pEstadoForm;

            if(aEstadoForm == Enumeradores.EnumEstadoForm.ALTERACAO)
            {
                aClienteEntidade = pClienteEntidade;
            }
        }

        private void FormManutencaoCliente_Load(object sender, EventArgs e)
        {
            if(aEstadoForm == Enumeradores.EnumEstadoForm.ALTERACAO)
            {
                TxtNome.Text = aClienteEntidade.vNome;
                TxtCpf.Text = aClienteEntidade.vCpf;
                TxtIdade.Text = aClienteEntidade.iIdade.ToString();
                TxtTelefone.Text = aClienteEntidade.vTelefone;
                TxtEmail.Text = aClienteEntidade.vEmail;
                TxtCelular.Text = aClienteEntidade.vCelular;

                TxtLogradouro.Text = aClienteEntidade.vEnderecoEntidade.vLogradouro;
                TxtNumero.Text = aClienteEntidade.vEnderecoEntidade.iNumero.ToString();
                TxtComplemento.Text = aClienteEntidade.vEnderecoEntidade.vComplemento;
                TxtBairro.Text = aClienteEntidade.vEnderecoEntidade.vBairro;
                TxtCidade.Text = aClienteEntidade.vEnderecoEntidade.vCidade;
                CboEstado.Text = aClienteEntidade.vEnderecoEntidade.vEstado;
                TxtCep.Text = aClienteEntidade.vEnderecoEntidade.vCep;
                TxtObservacao.Text = aClienteEntidade.vEnderecoEntidade.vObs;

                BtnCadastrar.Text = "&Alterar";
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteEntidade vClienteEntidade = new ClienteEntidade();

                vClienteEntidade.vNome = TxtNome.Text;
                vClienteEntidade.vCpf = TxtCpf.Text;
                vClienteEntidade.iIdade = Convert.ToInt16(TxtIdade.Text);
                vClienteEntidade.vTelefone = TxtTelefone.Text;
                vClienteEntidade.vEmail = TxtEmail.Text;
                vClienteEntidade.vCelular = TxtCelular.Text;
                if(RbtMasculino.Checked)
                {
                    vClienteEntidade.vSexo = "Masculino";
                }
                else
                {
                    vClienteEntidade.vSexo = "Feminino";
                }

                EnderecoEntidade vEnderecoEntidade = new EnderecoEntidade();

                vEnderecoEntidade.vLogradouro = TxtLogradouro.Text;
                vEnderecoEntidade.iNumero = Convert.ToInt32(TxtNumero.Text);
                vEnderecoEntidade.vComplemento = TxtComplemento.Text;
                vEnderecoEntidade.vBairro = TxtBairro.Text;
                vEnderecoEntidade.vCidade = TxtCidade.Text;
                vEnderecoEntidade.vEstado = CboEstado.Text;
                vEnderecoEntidade.vCep = TxtCep.Text;
                vEnderecoEntidade.vObs = TxtObservacao.Text;

                if(aClienteEntidade != null)
                {
                    vEnderecoEntidade.iId = aClienteEntidade.vEnderecoEntidade.iId;
                }

                vClienteEntidade.vEnderecoEntidade = vEnderecoEntidade;

                ClienteControlador vTbClienteControlador = new ClienteControlador();

                if(aEstadoForm == Enumeradores.EnumEstadoForm.CADASTRO)
                {
                    vTbClienteControlador.Incluir(vClienteEntidade);
                }
                else
                {
                    vClienteEntidade.iId = aClienteEntidade.iId;
                    vTbClienteControlador.Alterar(vClienteEntidade);
                }

                MessageBox.Show("Cliente salvo com sucesso"
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

        private void TxtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.PermitirApenasNumeroKeyPress(e);
        }
        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.PermitirApenasNumeroKeyPress(e);
        }
        
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}