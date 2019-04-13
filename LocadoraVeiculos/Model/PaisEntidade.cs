using System;

namespace Model
{
    public class PaisEntidade
    {
        public int iId { get; set; }
        public string vNome { get; set; }
        public string vIdiomaPrincipal { get; set; }
        public long iQtdHabitantes { get; set; }
        public int iAnoFundacao { get; set; }
        public decimal dPibEmDolar { get; set; }
    }
}