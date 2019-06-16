using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class FormLogin : FormPadrao
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Owner.Close();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            try
            {

                if(!validarCamposObrigatorios()) { return; }

                string vLogin = CboLogin.Text;
                string vSenha = TxtSenha.Text;

                UsuarioEntidade vUsuarioEntidade = VendedorEntidade.ValidarLogin(vLogin, vSenha);

                if(vUsuarioEntidade == null)
                {
                    MessageBox.Show("Senha errada"
                                    , "Aviso"
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Warning);
                    TxtSenha.Focus();
                } else
                {
                    this.Close();
                }

            } catch(Exception ex)
            {
                MessageBox.Show("Erro ao logar no sistema"
                                , "Erro"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            try
            {
                //carrega o combo de vendedores
                CboLogin.ValueMember = "iId";
                CboLogin.DisplayMember = "vLogin";

                //POLIMORFISMO, em tempo de execucao, o sistema sabe que o metodo consultar é da classe vendedor
                CboLogin.DataSource = VendedorEntidade.Consultar();

                //coloca o foco para o campo da senha
                this.ActiveControl = TxtSenha;

            } catch(Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de usuários"
                                , "Erro"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
            }
        }

        private bool validarCamposObrigatorios()
        {
            if (CboLogin.SelectedIndex < 0)
            {
                MessageBox.Show("Favor informar o login"
                                , "Aviso"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Warning);
                CboLogin.Focus();
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

                return true;
        }
    }
}