using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using Model;
using System.Data.SqlClient;

namespace LocadoraVeiculos.DAO
{
    public class VendedorDAO
    {
        public SqlDataReader Consultar(VendedorEntidade pVendedorEntidade)
        {
            List<SqlParameter> vListOfSqlParameter = new List<SqlParameter>();

            if (pVendedorEntidade.iId > 0)
            {
                vListOfSqlParameter.Add(Conexao.CriarParametro("@piId", DbType.Int32, pVendedorEntidade.iId));
            }
            else if (!string.IsNullOrWhiteSpace(pVendedorEntidade.vNome))
            {
                vListOfSqlParameter.Add(Conexao.CriarParametro("@pvNome", DbType.String, pVendedorEntidade.vNome));
            }

            return Conexao.ExecuteReader("SPSel_TbVendedor", vListOfSqlParameter);
        }

        public void Excluir(VendedorEntidade pVendedorEntidade)
        {
            List<SqlParameter> vListOfSqlParameter = new List<SqlParameter>();

            vListOfSqlParameter.Add(Conexao.CriarParametro("@piId", DbType.Int32, pVendedorEntidade.iId));

            Conexao.ExecuteNonQuery("SPDel_TbVendedor", vListOfSqlParameter);
        }

        public void Alterar(VendedorEntidade pVendedorEntidade)
        {
            Conexao.ExecuteNonQuery("SPUpd_TbVendedor", this.fnGetAllSqlParameters(pVendedorEntidade));
        }

        public int Incluir(VendedorEntidade pVendedorEntidade)
        {
            return Convert.ToInt32(Conexao.ExecuteScalar("SPIns_TbVendedor", this.fnGetAllSqlParameters(pVendedorEntidade)));
        }

        public List<SqlParameter> fnGetAllSqlParameters(VendedorEntidade pVendedorEntidade)
        {
            List<SqlParameter> vListOfSqlParameter = new List<SqlParameter>();

            if (pVendedorEntidade.iId > 0)
            {
                vListOfSqlParameter.Add(Conexao.CriarParametro("@piId", DbType.Int32, pVendedorEntidade.iId));
            }

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pvNome", DbType.String, pVendedorEntidade.vNome));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pvLogin", DbType.String, pVendedorEntidade.vLogin));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pvSenha", DbType.String, pVendedorEntidade.vSenha));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pbAtivo", DbType.Boolean, pVendedorEntidade.bAtivo));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pvCpf", DbType.String, pVendedorEntidade.vCpf));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pdSalario", DbType.Decimal, pVendedorEntidade.dSalario));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@piPercentualComissao", DbType.Int32, pVendedorEntidade.iPercentualComissao));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pdtDataAdmissao", DbType.DateTime, pVendedorEntidade.dtDataAdmissao));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pdtDataDemissao", DbType.DateTime, pVendedorEntidade.dtDataDemissao));

            return vListOfSqlParameter;
        }
    }
}