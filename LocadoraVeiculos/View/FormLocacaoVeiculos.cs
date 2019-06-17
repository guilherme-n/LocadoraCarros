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

            TxtVendedorLogado.Text = RecursosGlobais.VendedorLogado.vNome;
        }

        private void CboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            limparValores();

            //carrega o combo de veiculos
            VeiculoEntidade vVeiculoEntidade = new VeiculoEntidade();
            vVeiculoEntidade.vMontadoraEntidade.iId = Int32.Parse(CboMarca.SelectedValue.ToString());

            CboVeiculo.ValueMember = "iId";
            CboVeiculo.DisplayMember = "vModeloEPlaca";
            CboVeiculo.DataSource = VeiculoEntidade.Consultar(vVeiculoEntidade);
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
                vVeiculoEntidade = VeiculoEntidade.Consultar(vVeiculoEntidade).First();

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

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                AluguelEntidade vAluguelEntidade = new AluguelEntidade();
                vAluguelEntidade.vMontadoraEntidade.iId = Int32.Parse(CboMarca.SelectedValue.ToString());
                vAluguelEntidade.vVeiculoEntidade.iId = Int32.Parse(CboVeiculo.SelectedValue.ToString());
                vAluguelEntidade.vClienteEntidade.iId = Int32.Parse(CboCliente.SelectedValue.ToString());
                vAluguelEntidade.iQtdDiarias = Int32.Parse(TxtDiaria.Text);
                vAluguelEntidade.dValorTotal = Int32.Parse(TxtValorTotal.Text);
                vAluguelEntidade.iIdTbFormaPagamento = CboFormaPagamento.SelectedIndex + 1;
                vAluguelEntidade.vVendedorEntidade.iId = RecursosGlobais.VendedorLogado.iId;
                vAluguelEntidade.dtDataInicioAluguel = DtInicioAluguel.Value;

                vAluguelEntidade.Salvar();

                VeiculoEntidade vVeiculoEntidade = new VeiculoEntidade();
                vVeiculoEntidade.iId = Int32.Parse(CboVeiculo.SelectedValue.ToString());
                vVeiculoEntidade.Carregar();
                vVeiculoEntidade.iEstadoVeiculo = Enumeradores.EnumEstadoVeiculo.ALUGADO;
                vVeiculoEntidade.Salvar();

                MessageBox.Show("Locação efetuada com sucesso."
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
    }
}