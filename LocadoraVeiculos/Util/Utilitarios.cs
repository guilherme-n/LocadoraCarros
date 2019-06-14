using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Util
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

        public static string GerarHash(string vPalavra)
        {

            //Cria um objeto enconding para assegurar o padrão de encondig para o texto origem
            UnicodeEncoding vUnicodeEncoding = new UnicodeEncoding();

            //Retorna um byte array baseado no texto origem
            Byte[] vByteSourceText = vUnicodeEncoding.GetBytes(vPalavra);

            //Instancia um objeto MD5
            MD5CryptoServiceProvider Md5 = new MD5CryptoServiceProvider();

            //Calcula o valor do hash para o texto origem
            Byte[] vByteHash  = Md5.ComputeHash(vByteSourceText);

            //Converte o valor obtido para o formato string
            return Convert.ToBase64String(vByteHash);

        }
    }
}