using System;
using System.Data;
using System.Collections.Generic;
using Model;
using System.Data.SqlClient;

namespace LocadoraVeiculos.DAO
{
    public class MontadoraPaisDAO
    {
        public SqlDataReader Consultar(MontadoraPaisEntidade pMontadoraPaisEntidade)
        {
            List<SqlParameter> vListOfSqlParameter = new List<SqlParameter>();

            if (pMontadoraPaisEntidade.iId > 0)
            {
                vListOfSqlParameter.Add(Conexao.CriarParametro("@piId", DbType.Int32, pMontadoraPaisEntidade.iId));
            }

            return Conexao.ExecuteReader("SPSel_TbMontadoraPais", vListOfSqlParameter);
        }

        public void Excluir(MontadoraPaisEntidade pMontadoraPaisEntidade)
        {
            List<SqlParameter> vListOfSqlParameter = new List<SqlParameter>();

            vListOfSqlParameter.Add(Conexao.CriarParametro("@piId", DbType.Int32, pMontadoraPaisEntidade.iId));

            Conexao.ExecuteNonQuery("SPDel_TbMontadoraPais", vListOfSqlParameter);
        }

        public void Alterar(MontadoraPaisEntidade pMontadoraPaisEntidade)
        {
            Conexao.ExecuteNonQuery("SPUpd_TbMontadoraPais", this.fnGetAllSqlParameters(pMontadoraPaisEntidade));
        }

        public int Incluir(MontadoraPaisEntidade pMontadoraPaisEntidade)
        {
            return Convert.ToInt32(Conexao.ExecuteScalar("SPIns_TbMontadoraPais", this.fnGetAllSqlParameters(pMontadoraPaisEntidade)));
        }

        public List<SqlParameter> fnGetAllSqlParameters(MontadoraPaisEntidade pMontadoraPaisEntidade)
        {
            List<SqlParameter> vListOfSqlParameter = new List<SqlParameter>();

            if (pMontadoraPaisEntidade.iId > 0)
            {
                vListOfSqlParameter.Add(Conexao.CriarParametro("@piId", DbType.Int32, pMontadoraPaisEntidade.iId));
            }

            vListOfSqlParameter.Add(Conexao.CriarParametro("@piIdTbMontadora", DbType.Int32, pMontadoraPaisEntidade.iIdTbMontadora));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@piIdTbPais", DbType.Int32, pMontadoraPaisEntidade.iIdTbPais));

            return vListOfSqlParameter;
        }
    }
}