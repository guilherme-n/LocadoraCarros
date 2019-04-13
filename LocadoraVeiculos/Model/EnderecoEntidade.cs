using System;

namespace Model
{
    public class EnderecoEntidade
    {
        public int iId { get; set; }
        public string vLogradouro { get; set; }
        public int iNumero { get; set; }
        public string vComplemento { get; set; }
        public string vBairro { get; set; }
        public string vCidade { get; set; }
        public string vEstado { get; set; }
        public string vCep { get; set; }
        public DateTime dtDataCriacao { get; set; }
        public string vObs { get; set; }
        public int iIdTbCliente { get; set; }
    }
}