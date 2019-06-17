using System;
using System.Data;
using System.Collections.Generic;
using Model;
using System.Data.SqlClient;
using Util;

namespace DAO
{
    public class VeiculoDAO
    {

        public SqlDataReader Consultar(VeiculoEntidade pVeiculoEntidade)
        {
            List<SqlParameter> vListOfSqlParameter = new List<SqlParameter>();

            if (pVeiculoEntidade.iId > 0)
            {
                vListOfSqlParameter.Add(Conexao.CriarParametro("@piId", DbType.Int32, pVeiculoEntidade.iId));
            }
            else
            {
                if (pVeiculoEntidade.vMontadoraEntidade.iId > 0)
                {
                    vListOfSqlParameter.Add(Conexao.CriarParametro("@piIdMontadora", DbType.Int32, pVeiculoEntidade.vMontadoraEntidade.iId));
                }
            }

            return Conexao.ExecuteReader("SPSel_TbVeiculo", vListOfSqlParameter);
        }

        public SqlDataReader Consultar(Enumeradores.EnumEstadoVeiculo pEstadoVeiculo)
        {
            List<SqlParameter> vListOfSqlParameter = new List<SqlParameter>();

            vListOfSqlParameter.Add(Conexao.CriarParametro("@piEstadoVeiculo", DbType.Int32, pEstadoVeiculo));

            return Conexao.ExecuteReader("SPSel_TbVeiculo", vListOfSqlParameter);
        }

        public void Excluir(VeiculoEntidade pVeiculoEntidade)
        {
            List<SqlParameter> vListOfSqlParameter = new List<SqlParameter>();

            vListOfSqlParameter.Add(Conexao.CriarParametro("@piId", DbType.Int32, pVeiculoEntidade.iId));

            Conexao.ExecuteNonQuery("SPDel_TbVeiculo", vListOfSqlParameter);
        }

        public void Alterar(VeiculoEntidade pVeiculoEntidade)
        {
            Conexao.ExecuteNonQuery("SPUpd_TbVeiculo", this.fnGetAllSqlParameters(pVeiculoEntidade));
        }

        public int Incluir(VeiculoEntidade pVeiculoEntidade)
        {
            return Convert.ToInt32(Conexao.ExecuteScalar("SPIns_TbVeiculo", this.fnGetAllSqlParameters(pVeiculoEntidade)));
        }

        public List<SqlParameter> fnGetAllSqlParameters(VeiculoEntidade pVeiculoEntidade)
        {
            List<SqlParameter> vListOfSqlParameter = new List<SqlParameter>();

            if (pVeiculoEntidade.iId > 0)
            {
                vListOfSqlParameter.Add(Conexao.CriarParametro("@piId", DbType.Int32, pVeiculoEntidade.iId));
            }

            vListOfSqlParameter.Add(Conexao.CriarParametro("@piIdMontadora", DbType.Int32, pVeiculoEntidade.vMontadoraEntidade.iId));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pvModelo", DbType.String, pVeiculoEntidade.vModelo));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@piAnoFabricacao", DbType.Int32, pVeiculoEntidade.iAnoFabricacao));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pvCor", DbType.String, pVeiculoEntidade.vCor));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pdValorLocacao", DbType.Decimal, pVeiculoEntidade.dValorLocacao));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pvPlaca", DbType.String, pVeiculoEntidade.vPlaca));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@piQuilometragem", DbType.Int64, pVeiculoEntidade.iQuilometragem));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@piEstadoVeiculo", DbType.Int32, pVeiculoEntidade.iEstadoVeiculo));            

            return vListOfSqlParameter;
        }
    }
}