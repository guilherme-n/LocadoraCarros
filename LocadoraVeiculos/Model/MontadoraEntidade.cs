using System;

namespace Model
{
    public class MontadoraEntidade
    {
        public int iId { get; set; }
        public string vNome { get; set; }
        public decimal dFaturamentoEmDolar { get; set; }
        public decimal dLucroAnualEmDolar { get; set; }
        public string vCidadeFundacao { get; set; }
        public DateTime dtDataFundacao { get; set; }
        public int iQtdFabricas { get; set; }
    }
}