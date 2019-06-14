using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DAO;

namespace Model
{
    public class MontadoraEntidade
    {
        private static MontadoraDAO aTbMontadoraDAO = new MontadoraDAO();

        public int iId { get; set; }
        public string vNome { get; set; }
        public decimal dFaturamentoEmDolar { get; set; }
        public decimal dLucroAnualEmDolar { get; set; }
        public string vCidadeFundacao { get; set; }
        public DateTime dtDataFundacao { get; set; }
        public int iQtdFabricas { get; set; }

        private static MontadoraEntidade MontarObjeto(SqlDataReader pSqlDataReader)
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

        public static List<MontadoraEntidade> Consultar(MontadoraEntidade pMontadoraEntidade)
        {
            List<MontadoraEntidade> vListMontadoraEntidade = new List<MontadoraEntidade>();
            try
            {
                SqlDataReader vSqlDataReader = aTbMontadoraDAO.Consultar(pMontadoraEntidade);
                while (vSqlDataReader.Read())
                {
                    vListMontadoraEntidade.Add(MontarObjeto(vSqlDataReader));
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

        public void Salvar()
        {
            try
            {
                if (iId == 0)
                {
                    this.iId = aTbMontadoraDAO.Incluir(this);
                }
                else
                {
                    aTbMontadoraDAO.Alterar(this);
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
                aTbMontadoraDAO.Excluir(this);
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