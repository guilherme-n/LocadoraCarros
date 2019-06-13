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
            //carrega o combo de veiculos
            VeiculoControlador vVeiculoControlador = new VeiculoControlador();
            CboVeiculo.ValueMember = "iId";
            CboVeiculo.DisplayMember = "vNomeEQtdDisponivel";
            CboVeiculo.DataSource = vVeiculoControlador.Consultar(new VeiculoEntidade(), true);

            //carrega o combo de clientes
            ClienteControlador vClienteControlador = new ClienteControlador();
            CboCliente.ValueMember = "iId";
            CboCliente.DisplayMember = "vNomeECpf";
            CboCliente.DataSource = vClienteControlador.Consultar(new ClienteEntidade());

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
