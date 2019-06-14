using System;
using System.Linq;
using System.Windows.Forms;
using Model;
using Util;

namespace View
{
    public partial class FormLocacaoVeiculos : FormPadrao
    {
        public FormLocacaoVeiculos()
        {
            InitializeComponent();
        }

        private void FormLocacaoVeiculos_Load(object sender, EventArgs e)
        {
            CboFormaPagamento.SelectedIndex = 0;

            //carrega o combo de marcas
            CboMarca.ValueMember = "iId";
            CboMarca.DisplayMember = "vNome";
            CboMarca.DataSource = MontadoraEntidade.Consultar(new MontadoraEntidade());

            //carrega o combo de clientes
            CboCliente.ValueMember = "iId";
            CboCliente.DisplayMember = "vNomeECpf";
            CboCliente.DataSource = ClienteEntidade.Consultar(new ClienteEntidade());
        }

        private void CboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            limparValores();

            //carrega o combo de veiculos
            VeiculoEntidade vVeiculoEntidade = new VeiculoEntidade();
            vVeiculoEntidade.vMontadoraEntidade.iId = Int32.Parse(CboMarca.SelectedValue.ToString());

            CboVeiculo.ValueMember = "iId";
            CboVeiculo.DisplayMember = "vModeloEPlaca";
            CboVeiculo.DataSource = VeiculoEntidade.Consultar(vVeiculoEntidade, true);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.PermitirApenasNumeroKeyPress(e);
        }

        private void TxtDiaria_Validated(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(TxtDiaria.Text))
            {

                //Sai da funcao caso o combo de veiculos nao esteja carregado
                if(CboVeiculo.Items.Count == 0)
                {
                    return;
                }

                VeiculoEntidade vVeiculoEntidade = new VeiculoEntidade();
                vVeiculoEntidade.iId = Int32.Parse(CboVeiculo.SelectedValue.ToString());
                vVeiculoEntidade = VeiculoEntidade.Consultar(vVeiculoEntidade, false).First();

                TxtValorTotal.Text = (Int32.Parse(TxtDiaria.Text) * vVeiculoEntidade.dValorLocacao).ToString();
            }
        }

        private void limparValores()
        {
            TxtDiaria.Clear();
            TxtValorTotal.Clear();
        }

        private void CboVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            limparValores();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}