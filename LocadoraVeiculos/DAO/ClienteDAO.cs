using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Model;

namespace LocadoraVeiculos.DAO
{
    public class ClienteDAO
    {
        public SqlDataReader Consultar(ClienteEntidade pClienteEntidade)
        {
            List<SqlParameter> vListOfSqlParameter = new List<SqlParameter>();

            if (pClienteEntidade.iId > 0)
            {
                vListOfSqlParameter.Add(Conexao.CriarParametro("@piId", DbType.Int32, pClienteEntidade.iId));
            }

            return Conexao.ExecuteReader("SPSel_TbCliente", vListOfSqlParameter);
        }

        public void Excluir(ClienteEntidade pClienteEntidade)
        {
            List<SqlParameter> vListOfSqlParameter = new List<SqlParameter>();

            vListOfSqlParameter.Add(Conexao.CriarParametro("@piId", DbType.Int32, pClienteEntidade.iId));

            Conexao.ExecuteNonQuery("SPDel_TbCliente", vListOfSqlParameter);
        }


        public void Alterar(ClienteEntidade pClienteEntidade)
        {
            Conexao.ExecuteNonQuery("SPUpd_TbCliente", this.fnGetAllSqlParameters(pClienteEntidade));
        }

        public int Incluir(ClienteEntidade pClienteEntidade)
        {
            return Convert.ToInt32(Conexao.ExecuteScalar("SPIns_TbCliente", this.fnGetAllSqlParameters(pClienteEntidade)));
        }

        public List<SqlParameter> fnGetAllSqlParameters(ClienteEntidade pClienteEntidade)
        {
            List<SqlParameter> vListOfSqlParameter = new List<SqlParameter>();

            if (pClienteEntidade.iId > 0)
            {
                vListOfSqlParameter.Add(Conexao.CriarParametro("@piId", DbType.Int32, pClienteEntidade.iId));
            }

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pvNome", DbType.String, pClienteEntidade.vNome));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pvCpf", DbType.String, pClienteEntidade.vCpf));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@piIdade", DbType.Int16, pClienteEntidade.iIdade));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pvTelefone", DbType.String, pClienteEntidade.vTelefone));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pvEmail", DbType.String, pClienteEntidade.vEmail));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pvCelular", DbType.String, pClienteEntidade.vCelular));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pvSexo", DbType.String, pClienteEntidade.vSexo));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pdtDataCadastro", DbType.DateTime, pClienteEntidade.dtDataCadastro));

            return vListOfSqlParameter;
        }
    }
}