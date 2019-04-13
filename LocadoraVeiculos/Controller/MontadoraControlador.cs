using System;
using System.Data.Common;
using System.Collections.Generic;
using Model;
using LocadoraVeiculos.DAO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Controller
{
    public class MontadoraControlador
    {
        private MontadoraDAO aTbMontadoraDAO;

        public MontadoraControlador()
        {
            this.aTbMontadoraDAO = new MontadoraDAO();
        }

        private MontadoraEntidade fnMontarObjeto(SqlDataReader pSqlDataReader)
        {
            MontadoraEntidade vMontadoraEntidade = new MontadoraEntidade();

            vMontadoraEntidade.iId = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iId"], DBNull.Value)) ? pSqlDataReader["iId"] : 0);

            vMontadoraEntidade.vNome = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vNome"], DBNull.Value)) ? pSqlDataReader["vNome"] : string.Empty);

            vMontadoraEntidade.dFaturamentoEmDolar = Convert.ToDecimal((!object.ReferenceEquals(pSqlDataReader["dFaturamentoEmDolar"], DBNull.Value)) ? pSqlDataReader["dFaturamentoEmDolar"] : 0);

            vMontadoraEntidade.dLucroAnualEmDolar = Convert.ToDecimal((!object.ReferenceEquals(pSqlDataReader["dLucroAnualEmDolar"], DBNull.Value)) ? pSqlDataReader["dLucroAnualEmDolar"] : 0);

            vMontadoraEntidade.vCidadeFundacao = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vCidadeFundacao"], DBNull.Value)) ? pSqlDataReader["vCidadeFundacao"] : string.Empty);

            vMontadoraEntidade.dtDataFundacao = Convert.ToDateTime((!object.ReferenceEquals(pSqlDataReader["dtDataFundacao"], DBNull.Value)) ? pSqlDataReader["dtDataFundacao"] : DateTime.MinValue);

            vMontadoraEntidade.iQtdFabricas = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iQtdFabricas"], DBNull.Value)) ? pSqlDataReader["iQtdFabricas"] : 0);

            return vMontadoraEntidade;
        }

        public List<MontadoraEntidade> Consultar(MontadoraEntidade pMontadoraEntidade)
        {
            List<MontadoraEntidade> vListMontadoraEntidade = new List<MontadoraEntidade>();
            try
            {
                SqlDataReader vSqlDataReader = this.aTbMontadoraDAO.Consultar(pMontadoraEntidade);
                while (vSqlDataReader.Read())
                {
                    vListMontadoraEntidade.Add(this.fnMontarObjeto(vSqlDataReader));
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

            return vListMontadoraEntidade;
        }

        public MontadoraEntidade Incluir(MontadoraEntidade pMontadoraEntidade)
        {
            try
            {
                pMontadoraEntidade.iId = 0;
                pMontadoraEntidade.iId = this.aTbMontadoraDAO.Incluir(pMontadoraEntidade);
                return pMontadoraEntidade;
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

        public void Alterar(MontadoraEntidade pMontadoraEntidade)
        {
            try
            {
                this.aTbMontadoraDAO.Alterar(pMontadoraEntidade);
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

        public void Excluir(MontadoraEntidade pMontadoraEntidade)
        {
            try
            {
                this.aTbMontadoraDAO.Excluir(pMontadoraEntidade);
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