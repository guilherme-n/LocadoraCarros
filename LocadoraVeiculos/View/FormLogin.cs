using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;

namespace LocadoraVeiculos.View
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

                VendedorEntidade vVendedorEntidade = new VendedorEntidade();
                vVendedorEntidade.iId = int.Parse(CboLogin.SelectedValue.ToString());
                vVendedorEntidade.vSenha = TxtSenha.Text;

                VendedorControlador vVendedorControlador = new VendedorControlador();
                List<VendedorEntidade> vListOfVendedorEntidade = vVendedorControlador.Consultar(vVendedorEntidade);

                if(vListOfVendedorEntidade.Count == 0)
                {
                    MessageBox.Show("Login/senha errados"
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
                VendedorControlador vVendedorControlador = new VendedorControlador();
                CboLogin.ValueMember = "iId";
                CboLogin.DisplayMember = "vLogin";
                CboLogin.DataSource= vVendedorControlador.Consultar(new VendedorEntidade());

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
