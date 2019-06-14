using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DAO;

namespace Model
{
    public class PaisEntidade
    {
        private static PaisDAO aTbPaisDAO;

        public int iId { get; set; }
        public string vNome { get; set; }
        public string vIdiomaPrincipal { get; set; }
        public long iQtdHabitantes { get; set; }
        public int iAnoFundacao { get; set; }
        public decimal dPibEmDolar { get; set; }

        public PaisEntidade()
        {
            aTbPaisDAO = new PaisDAO();
        }

        private static PaisEntidade MontarObjeto(SqlDataReader pSqlDataReader)
        {
            PaisEntidade vPaisEntidade = new PaisEntidade();

            vPaisEntidade.iId = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iId"], DBNull.Value)) ? pSqlDataReader["iId"] : 0);

            vPaisEntidade.vNome = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vNome"], DBNull.Value)) ? pSqlDataReader["vNome"] : string.Empty);

            vPaisEntidade.vIdiomaPrincipal = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vIdiomaPrincipal"], DBNull.Value)) ? pSqlDataReader["vIdiomaPrincipal"] : string.Empty);

            vPaisEntidade.iQtdHabitantes = Convert.ToInt64((!object.ReferenceEquals(pSqlDataReader["iQtdHabitantes"], DBNull.Value)) ? pSqlDataReader["iQtdHabitantes"] : 0);

            vPaisEntidade.iAnoFundacao = Convert.ToInt16((!object.ReferenceEquals(pSqlDataReader["iAnoFundacao"], DBNull.Value)) ? pSqlDataReader["iAnoFundacao"] : 0);

            vPaisEntidade.dPibEmDolar = Convert.ToDecimal((!object.ReferenceEquals(pSqlDataReader["dPibEmDolar"], DBNull.Value)) ? pSqlDataReader["dPibEmDolar"] : 0);

            return vPaisEntidade;
        }

        public static List<PaisEntidade> Consultar(PaisEntidade pPaisEntidade)
        {
            List<PaisEntidade> vListPaisEntidade = new List<PaisEntidade>();
            try
            {
                SqlDataReader vSqlDataReader = aTbPaisDAO.Consultar(pPaisEntidade);
                while (vSqlDataReader.Read())
                {
                    vListPaisEntidade.Add(MontarObjeto(vSqlDataReader));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("consultar o(s) registro(s)");
            }
            finally
            {
                Conexao.CloseConnection();
            }

            return vListPaisEntidade;
        }

        public void Salvar()
        {
            try
            {
                if(iId == 0)
                {
                    aTbPaisDAO.Incluir(this);
                }
                else
                {
                    aTbPaisDAO.Alterar(this);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("salvar o registro");
            }
            finally
            {
                Conexao.CloseConnection();
            }
        }

        public void Excluir()
        {
            try
            {
                aTbPaisDAO.Excluir(this);
            }
            catch (Exception ex)
            {
                throw new Exception("excluir o registro");
            }
            finally
            {
                Conexao.CloseConnection();
            }
        }
    }
}