using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using Model;
using System.Data.SqlClient;

namespace LocadoraVeiculos.DAO
{
    public class EnderecoDAO
    {
        public SqlDataReader Consultar(EnderecoEntidade pEnderecoEntidade)
        {
            List<SqlParameter> vListOfSqlParameter = new List<SqlParameter>();

            if (pEnderecoEntidade.iId > 0)
            {
                vListOfSqlParameter.Add(Conexao.CriarParametro("@piId", DbType.Int32, pEnderecoEntidade.iId));
            }

            return Conexao.ExecuteReader("SPSel_TbEndereco", vListOfSqlParameter);
        }

        public void Excluir(EnderecoEntidade pEnderecoEntidade)
        {
            List<SqlParameter> vListOfSqlParameter = new List<SqlParameter>();

            vListOfSqlParameter.Add(Conexao.CriarParametro("@piId", DbType.Int32, pEnderecoEntidade.iId));

            Conexao.ExecuteNonQuery("SPDel_TbEndereco", vListOfSqlParameter);
        }

        public void Alterar(EnderecoEntidade pEnderecoEntidade)
        {
            Conexao.ExecuteNonQuery("SPUpd_TbEndereco", this.fnGetAllSqlParameters(pEnderecoEntidade));
        }

        public int Incluir(EnderecoEntidade pEnderecoEntidade)
        {
            return Convert.ToInt32(Conexao.ExecuteScalar("SPIns_TbEndereco", this.fnGetAllSqlParameters(pEnderecoEntidade)));
        }

        public List<SqlParameter> fnGetAllSqlParameters(EnderecoEntidade pEnderecoEntidade)
        {
            List<SqlParameter> vListOfSqlParameter = new List<SqlParameter>();

            if (pEnderecoEntidade.iId > 0)
            {
                vListOfSqlParameter.Add(Conexao.CriarParametro("@piId", DbType.Int32, pEnderecoEntidade.iId));
            }

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pvLogradouro", DbType.String, pEnderecoEntidade.vLogradouro));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@piNumero", DbType.Int32, pEnderecoEntidade.iNumero));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pvComplemento", DbType.String, pEnderecoEntidade.vComplemento));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pvBairro", DbType.String, pEnderecoEntidade.vBairro));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pvCidade", DbType.String, pEnderecoEntidade.vCidade));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pvEstado", DbType.String, pEnderecoEntidade.vEstado));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pvCep", DbType.String, pEnderecoEntidade.vCep));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pdtDataCriacao", DbType.DateTime, pEnderecoEntidade.dtDataCriacao));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pvObs", DbType.String, pEnderecoEntidade.vObs));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@piIdTbCliente", DbType.Int32, pEnderecoEntidade.iIdTbCliente));

            return vListOfSqlParameter;
        }
    }
}