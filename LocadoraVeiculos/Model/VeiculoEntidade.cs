using System;

namespace Model
{
    public class VeiculoEntidade
    {
        public int iId { get; set; }
        public MontadoraEntidade vMontadoraEntidade { get; set; }
        public string vModelo { get; set; }
        public int iAnoFabricacao { get; set; }
        public string vCor { get; set; }
        public int iQtd { get; set; }
        public int iQtdDisponivel { get; set; }

        public string vNomeMontadora
        {
            get
            {
                return vMontadoraEntidade.vNome;
            }
        }

        public string vNomeEQtdDisponivel
        {
            get
            {
                return vModelo + " - " + iQtdDisponivel.ToString();
            }
        }

        public VeiculoEntidade()
        {
            vMontadoraEntidade = new MontadoraEntidade();
        }
    }
}