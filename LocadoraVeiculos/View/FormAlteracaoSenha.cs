using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Util;

namespace View
{
    public partial class FormAlteracaoSenha : FormPadrao
    {
        public FormAlteracaoSenha()
        {
            InitializeComponent();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if(!validarCamposObrigatorios()) { return; }

                VendedorEntidade vVendedorEntidade = RecursosGlobais.VendedorLogado;
                vVendedorEntidade.vSenha = TxtSenha.Text;
                vVendedorEntidade.AlterarSenha();

                MessageBox.Show("Senha alterada com sucesso."
                                , "Informação"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                this.Close();

            } catch(Exception ex)
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

        private bool validarCamposObrigatorios()
        {

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

            return true;
        }

        private void FormAlteracaoSenha_Load(object sender, EventArgs e)
        {
            TxtNomeVendedor.Text = RecursosGlobais.VendedorLogado.vNome;
        }
    }
}