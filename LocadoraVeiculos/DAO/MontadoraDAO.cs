using System;
using System.Data;
using System.Collections.Generic;
using Model;
using System.Data.SqlClient;

namespace DAO
{
    public class MontadoraDAO
    {
        public SqlDataReader Consultar(MontadoraEntidade pMontadoraEntidade)
        {
            List<SqlParameter> vListOfSqlParameter = new List<SqlParameter>();

            if (pMontadoraEntidade.iId > 0)
            {
                vListOfSqlParameter.Add(Conexao.CriarParametro("@piId", DbType.Int32, pMontadoraEntidade.iId));
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(pMontadoraEntidade.vNome))
                {
                    vListOfSqlParameter.Add(Conexao.CriarParametro("@pvNome", DbType.String, pMontadoraEntidade.vNome));
                }
            }

            return Conexao.ExecuteReader("SPSel_TbMontadora", vListOfSqlParameter);
        }

        public void Excluir(MontadoraEntidade pMontadoraEntidade)
        {
            List<SqlParameter> vListOfSqlParameter = new List<SqlParameter>();

            vListOfSqlParameter.Add(Conexao.CriarParametro("@piId", DbType.Int32, pMontadoraEntidade.iId));

            Conexao.ExecuteNonQuery("SPDel_TbMontadora", vListOfSqlParameter);
        }

        public void Alterar(MontadoraEntidade pMontadoraEntidade)
        {
            Conexao.ExecuteNonQuery("SPUpd_TbMontadora", this.fnGetAllSqlParameters(pMontadoraEntidade));
        }

        public int Incluir(MontadoraEntidade pMontadoraEntidade)
        {
            return Convert.ToInt32(Conexao.ExecuteScalar("SPIns_TbMontadora", this.fnGetAllSqlParameters(pMontadoraEntidade)));
        }

        public List<SqlParameter> fnGetAllSqlParameters(MontadoraEntidade pMontadoraEntidade)
        {
            List<SqlParameter> vListOfSqlParameter = new List<SqlParameter>();

            if (pMontadoraEntidade.iId > 0)
            {
                vListOfSqlParameter.Add(Conexao.CriarParametro("@piId", DbType.Int32, pMontadoraEntidade.iId));
            }

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pvNome", DbType.String, pMontadoraEntidade.vNome));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pdFaturamentoEmDolar", DbType.Decimal, pMontadoraEntidade.dFaturamentoEmDolar));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pdLucroAnualEmDolar", DbType.Decimal, pMontadoraEntidade.dLucroAnualEmDolar));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pvCidadeFundacao", DbType.String, pMontadoraEntidade.vCidadeFundacao));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pdtDataFundacao", DbType.DateTime, pMontadoraEntidade.dtDataFundacao));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@piQtdFabricas", DbType.Int32, pMontadoraEntidade.iQtdFabricas));

            return vListOfSqlParameter;
        }
    }
}