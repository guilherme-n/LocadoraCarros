using System;

namespace Model
{
    public class VendedorEntidade : UsuarioEntidade
    {
        public int iId { get; set; }
        public string vCpf { get; set; }
        public decimal dSalario { get; set; }
        public int iPercentualComissao { get; set; }
        public DateTime dtDataAdmissao { get; set; }
        public DateTime dtDataDemissao { get; set; }
    }
}