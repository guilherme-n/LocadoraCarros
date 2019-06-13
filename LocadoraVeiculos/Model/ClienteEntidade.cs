using System;

namespace Model
{
    public class ClienteEntidade
    {
        public int iId { get; set; }
        public string vNome { get; set; }
        public string vCpf { get; set; }
        public short iIdade { get; set; }
        public string vTelefone { get; set; }
        public string vEmail { get; set; }
        public string vCelular { get; set; }
        public string vSexo { get; set; }
        public DateTime dtDataCadastro { get; set; }
        public EnderecoEntidade vEnderecoEntidade { get; set; }

        public string vNomeECpf
        {
            get
            {
                return vNome + " - " + vCpf;
            }
        }
    }
}