using System;
using System.Windows.Forms;

namespace LocadoraVeiculos.Util
{
    static class Utilitarios
    {
        public static void PermitirApenasNumeroKeyPress(KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && Convert.ToChar(Keys.Back) != e.KeyChar)
            {
                e.Handled = true;
            }
        }
    }
}
