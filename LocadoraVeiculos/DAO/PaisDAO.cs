using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using Model;
using System.Data.SqlClient;

namespace DAO
{
    public class PaisDAO
    {
        public SqlDataReader Consultar(PaisEntidade pPaisEntidade)
        {
            List<SqlParameter> vListOfSqlParameter = new List<SqlParameter>();

            if (pPaisEntidade.iId > 0)
            {
                vListOfSqlParameter.Add(Conexao.CriarParametro("@piId", DbType.Int32, pPaisEntidade.iId));
            }
            else if (!string.IsNullOrWhiteSpace(pPaisEntidade.vNome))
            {
                vListOfSqlParameter.Add(Conexao.CriarParametro("@pvNome", DbType.String, pPaisEntidade.vNome));
            }

            return Conexao.ExecuteReader("SPSel_TbPais", vListOfSqlParameter);
        }

        public void Excluir(PaisEntidade pPaisEntidade)
        {
            List<SqlParameter> vListOfSqlParameter = new List<SqlParameter>();

            vListOfSqlParameter.Add(Conexao.CriarParametro("@piId", DbType.Int32, pPaisEntidade.iId));

            Conexao.ExecuteNonQuery("SPDel_TbPais", vListOfSqlParameter);
        }

        public void Alterar(PaisEntidade pPaisEntidade)
        {
            Conexao.ExecuteNonQuery("SPUpd_TbPais", this.fnGetAllSqlParameters(pPaisEntidade));
        }

        public int Incluir(PaisEntidade pPaisEntidade)
        {
            return Convert.ToInt32(Conexao.ExecuteScalar("SPIns_TbPais", this.fnGetAllSqlParameters(pPaisEntidade)));
        }

        public List<SqlParameter> fnGetAllSqlParameters(PaisEntidade pPaisEntidade)
        {
            List<SqlParameter> vListOfSqlParameter = new List<SqlParameter>();

            if (pPaisEntidade.iId > 0)
            {
                vListOfSqlParameter.Add(Conexao.CriarParametro("@piId", DbType.Int32, pPaisEntidade.iId));
            }

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pvNome", DbType.String, pPaisEntidade.vNome));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pvIdiomaPrincipal", DbType.String, pPaisEntidade.vIdiomaPrincipal));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@piQtdHabitantes", DbType.Int64, pPaisEntidade.iQtdHabitantes));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@piAnoFundacao", DbType.Int16, pPaisEntidade.iAnoFundacao));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pdPibEmDolar", DbType.Decimal, pPaisEntidade.dPibEmDolar));

            return vListOfSqlParameter;
        }
    }
}