using System;
using System.Data.Common;
using System.Collections.Generic;
using Model;
using DAO;
using System.Data.SqlClient;

namespace Controller
{
    public class MontadoraPaisControlador
    {
        private MontadoraPaisDAO aTbMontadoraPaisDAO;

        public MontadoraPaisControlador()
        {
            this.aTbMontadoraPaisDAO = new MontadoraPaisDAO();
        }

        private MontadoraPaisEntidade fnMontarObjeto(SqlDataReader pSqlDataReader)
        {
            MontadoraPaisEntidade vMontadoraPaisEntidade = new MontadoraPaisEntidade();

            vMontadoraPaisEntidade.iId = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iId"], DBNull.Value)) ? pSqlDataReader["iId"] : 0);

            vMontadoraPaisEntidade.iIdTbMontadora = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iIdTbMontadora"], DBNull.Value)) ? pSqlDataReader["iIdTbMontadora"] : 0);

            vMontadoraPaisEntidade.iIdTbPais = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iIdTbPais"], DBNull.Value)) ? pSqlDataReader["iIdTbPais"] : 0);

            return vMontadoraPaisEntidade;
        }

        public List<MontadoraPaisEntidade> Consultar(MontadoraPaisEntidade pMontadoraPaisEntidade)
        {
            List<MontadoraPaisEntidade> vListMontadoraPaisEntidade = new List<MontadoraPaisEntidade>();
            try
            {
                SqlDataReader vSqlDataReader = this.aTbMontadoraPaisDAO.Consultar(pMontadoraPaisEntidade);
                while (vSqlDataReader.Read())
                {
                    vListMontadoraPaisEntidade.Add(this.fnMontarObjeto(vSqlDataReader));
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

            return vListMontadoraPaisEntidade;
        }

        public MontadoraPaisEntidade Incluir(MontadoraPaisEntidade pMontadoraPaisEntidade)
        {
            try
            {
                pMontadoraPaisEntidade.iId = 0;
                pMontadoraPaisEntidade.iId = this.aTbMontadoraPaisDAO.Incluir(pMontadoraPaisEntidade);
                return pMontadoraPaisEntidade;
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

        public void Alterar(MontadoraPaisEntidade pMontadoraPaisEntidade)
        {
            try
            {
                this.aTbMontadoraPaisDAO.Alterar(pMontadoraPaisEntidade);
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

        public void Excluir(MontadoraPaisEntidade pMontadoraPaisEntidade)
        {
            try
            {
                this.aTbMontadoraPaisDAO.Excluir(pMontadoraPaisEntidade);
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