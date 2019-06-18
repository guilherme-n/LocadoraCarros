using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    static class Conexao
    {
        //static readonly String aStringConexao = "Data Source = DESKTOP-3S93RIL\\SQLEXPRESS; Initial Catalog = dbLocadoraVeiculos; Integrated Security = True; Connect Timeout = 30; User Instance = True; Trusted_Connection = True";
        static readonly String aStringConexao = "Server= DESENV_003; Database= dbLocadoraVeiculos; Integrated Security=True;";
        static SqlConnection aSqlConnection = new SqlConnection(aStringConexao);


        public static SqlDataReader ExecuteReader(string pProcedure, List<SqlParameter> pListSqlParameter)
        {
            if (aSqlConnection.State == ConnectionState.Closed)
            {
                aSqlConnection.Open();
            }

            SqlCommand vSqlCommand = new SqlCommand();
            vSqlCommand.Connection = aSqlConnection;
            vSqlCommand.CommandText = pProcedure;
            vSqlCommand.CommandType = CommandType.StoredProcedure;

            foreach(SqlParameter vSqlParameter in pListSqlParameter)
            {
                vSqlCommand.Parameters.Add(vSqlParameter);
            }

            return vSqlCommand.ExecuteReader();
        }

        public static object ExecuteScalar(string pProcedure, List<SqlParameter> pListSqlParameter)
        {
            if (aSqlConnection.State == ConnectionState.Closed)
            {
                aSqlConnection.Open();
            }

            SqlCommand vSqlCommand = new SqlCommand();
            vSqlCommand.Connection = aSqlConnection;
            vSqlCommand.CommandText = pProcedure;
            vSqlCommand.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter vSqlParameter in pListSqlParameter)
            {
                vSqlCommand.Parameters.Add(vSqlParameter);
            }

            return vSqlCommand.ExecuteScalar();
        }

        public static void ExecuteNonQuery(string pProcedure, List<SqlParameter> pListSqlParameter)
        {
            if (aSqlConnection.State == ConnectionState.Closed)
            {
                aSqlConnection.Open();
            }

            SqlCommand vSqlCommand = new SqlCommand();
            vSqlCommand.Connection = aSqlConnection;
            vSqlCommand.CommandText = pProcedure;
            vSqlCommand.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter vSqlParameter in pListSqlParameter)
            {
                vSqlCommand.Parameters.Add(vSqlParameter);
            }

            vSqlCommand.ExecuteNonQuery();
        }

        public static DataSet Fill(string pProcedure, List<SqlParameter> pListSqlParameter)
        {
            if (aSqlConnection.State == ConnectionState.Closed)
            {
                aSqlConnection.Open();
            }

            SqlCommand vSqlCommand = new SqlCommand();
            vSqlCommand.Connection = aSqlConnection;
            vSqlCommand.CommandText = pProcedure;
            vSqlCommand.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter vSqlParameter in pListSqlParameter)
            {
                vSqlCommand.Parameters.Add(vSqlParameter);
            }

            SqlDataAdapter vSqlDataAdapter = new SqlDataAdapter();

            vSqlDataAdapter.SelectCommand = vSqlCommand;

            DataSet vDataSet = new DataSet();

            vSqlDataAdapter.Fill(vDataSet);

            return vDataSet;
        }

        public static SqlParameter CriarParametro(string pNomeParametro, DbType pTipo, object pValor)
        {
            SqlParameter vSqlParameter = new SqlParameter();

            vSqlParameter.ParameterName = pNomeParametro;
            vSqlParameter.DbType = pTipo;
            vSqlParameter.Value = pValor;

            return vSqlParameter;
        }

        public static void CloseConnection()
        {
            aSqlConnection.Close();
        }
    }
}
