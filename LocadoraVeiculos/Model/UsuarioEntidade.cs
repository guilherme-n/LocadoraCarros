using System;

namespace Model
{
    public abstract class UsuarioEntidade
    {
        public string vNome { get; set; }
        public string vLogin { get; set; }
        public string vSenha { get; set; }
        public bool bAtivo { get; set; }
    }
}