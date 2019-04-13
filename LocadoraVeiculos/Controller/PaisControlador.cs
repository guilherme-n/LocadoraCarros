using System;
using System.Data.Common;
using System.Collections.Generic;
using Model;
using LocadoraVeiculos.DAO;
using System.Data.SqlClient;

namespace Controller
{
    public class PaisControlador
    {
        private PaisDAO aTbPaisDAO;

        public PaisControlador()
        {
            this.aTbPaisDAO = new PaisDAO();
        }

        private PaisEntidade fnMontarObjeto(SqlDataReader pSqlDataReader)
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

        public List<PaisEntidade> Consultar(PaisEntidade pPaisEntidade)
        {
            List<PaisEntidade> vListPaisEntidade = new List<PaisEntidade>();
            try
            {
                SqlDataReader vSqlDataReader = this.aTbPaisDAO.Consultar(pPaisEntidade);
                while (vSqlDataReader.Read())
                {
                    vListPaisEntidade.Add(this.fnMontarObjeto(vSqlDataReader));
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

        public PaisEntidade Incluir(PaisEntidade pPaisEntidade)
        {
            try
            {
                pPaisEntidade.iId = 0;
                pPaisEntidade.iId = this.aTbPaisDAO.Incluir(pPaisEntidade);
                return pPaisEntidade;
            }
            catch (Exception ex)
            {
                throw new Exception("incluir o registro");
            }
            finally
            {
                Conexao.CloseConnection();
            }
        }

        public void Alterar(PaisEntidade pPaisEntidade)
        {
            try
            {
                this.aTbPaisDAO.Alterar(pPaisEntidade);
            }
            catch (Exception ex)
            {
                throw new Exception("alterar o registro");
            }
            finally
            {
                Conexao.CloseConnection();
            }
        }

        public void Excluir(PaisEntidade pPaisEntidade)
        {
            try
            {
                this.aTbPaisDAO.Excluir(pPaisEntidade);
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