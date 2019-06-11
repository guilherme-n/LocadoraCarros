using System;
using System.Data;
using System.Collections.Generic;
using Model;
using System.Data.SqlClient;

namespace LocadoraVeiculos.DAO
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

            vListOfSqlParameter.Add(Conexao.CriarParametro("@piIdMontadora", DbType.Int32, pVeiculoEntidade.iIdMontadora));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pvModelo", DbType.String, pVeiculoEntidade.vModelo));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pdtAnoFabricacao", DbType.DateTime, pVeiculoEntidade.dtAnoFabricacao));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@piQtdLugares", DbType.Int32, pVeiculoEntidade.iQtdLugares));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pbTracaoNasQuatroRodas", DbType.Boolean, pVeiculoEntidade.bTracaoNasQuatroRodas));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@piIdMotor", DbType.Int32, pVeiculoEntidade.iIdMotor));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@pvCor", DbType.String, pVeiculoEntidade.vCor));

            vListOfSqlParameter.Add(Conexao.CriarParametro("@piPesoEmKg", DbType.Int32, pVeiculoEntidade.iPesoEmKg));

            return vListOfSqlParameter;
        }
    }
}