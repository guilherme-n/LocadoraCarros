using System;

namespace Model
{
    public class VeiculoEntidade
    {
        public int iId { get; set; }
        public int iIdMontadora { get; set; }
        public string vModelo { get; set; }
        public DateTime dtAnoFabricacao { get; set; }
        public int iQtdLugares { get; set; }
        public bool bTracaoNasQuatroRodas { get; set; }
        public int iIdMotor { get; set; }
        public string vCor { get; set; }
        public int iPesoEmKg { get; set; }
    }
}