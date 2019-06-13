using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public abstract class UsuarioControlador
    {
        public abstract List<UsuarioEntidade> Consultar(UsuarioEntidade pUsuarioEntidade);
    }
}