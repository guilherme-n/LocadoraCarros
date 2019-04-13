using System;
using System.Collections.Generic;
using Model;
using LocadoraVeiculos.DAO;
using System.Data.SqlClient;

namespace Controller
{
    public class VeiculoControlador
    {
        private VeiculoDAO aTbVeiculoDAO;

        public VeiculoControlador()
        {
            this.aTbVeiculoDAO = new VeiculoDAO();
        }

        private VeiculoEntidade fnMontarObjeto(SqlDataReader pSqlDataReader)
        {
            VeiculoEntidade vVeiculoEntidade = new VeiculoEntidade();

            vVeiculoEntidade.iId = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iId"], DBNull.Value)) ? pSqlDataReader["iId"] : 0);

            vVeiculoEntidade.iIdMontadora = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iIdMontadora"], DBNull.Value)) ? pSqlDataReader["iIdMontadora"] : 0);

            vVeiculoEntidade.vModelo = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vModelo"], DBNull.Value)) ? pSqlDataReader["vModelo"] : string.Empty);

            vVeiculoEntidade.dtAnoFabricacao = Convert.ToDateTime((!object.ReferenceEquals(pSqlDataReader["dtAnoFabricacao"], DBNull.Value)) ? pSqlDataReader["dtAnoFabricacao"] : DateTime.MinValue);

            vVeiculoEntidade.iQtdLugares = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iQtdLugares"], DBNull.Value)) ? pSqlDataReader["iQtdLugares"] : 0);

            vVeiculoEntidade.iIdCategoria = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iIdCategoria"], DBNull.Value)) ? pSqlDataReader["iIdCategoria"] : 0);

            vVeiculoEntidade.bTracaoNasQuatroRodas = Convert.ToBoolean((!object.ReferenceEquals(pSqlDataReader["bTracaoNasQuatroRodas"], DBNull.Value)) ? pSqlDataReader["bTracaoNasQuatroRodas"] : false);

            vVeiculoEntidade.iIdMotor = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iIdMotor"], DBNull.Value)) ? pSqlDataReader["iIdMotor"] : 0);

            vVeiculoEntidade.vCor = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vCor"], DBNull.Value)) ? pSqlDataReader["vCor"] : string.Empty);

            vVeiculoEntidade.iPesoEmKg = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iPesoEmKg"], DBNull.Value)) ? pSqlDataReader["iPesoEmKg"] : 0);

            return vVeiculoEntidade;
        }

        public List<VeiculoEntidade> Consultar(VeiculoEntidade pVeiculoEntidade)
        {
            List<VeiculoEntidade> vListVeiculoEntidade = new List<VeiculoEntidade>();
            try
            {
                SqlDataReader vSqlDataReader = this.aTbVeiculoDAO.Consultar(pVeiculoEntidade);
                while (vSqlDataReader.Read())
                {
                    vListVeiculoEntidade.Add(this.fnMontarObjeto(vSqlDataReader));
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

            return vListVeiculoEntidade;
        }

        public VeiculoEntidade Incluir(VeiculoEntidade pVeiculoEntidade)
        {
            try
            {
                pVeiculoEntidade.iId = 0;
                pVeiculoEntidade.iId = this.aTbVeiculoDAO.Incluir(pVeiculoEntidade);
                return pVeiculoEntidade;
            }
            catch (Exception ex)
            {
                throw new Exception("incluir o registro");
            }
            finally
            {
                Conexao.CloseConnection();
            }
        }

        public void Alterar(VeiculoEntidade pVeiculoEntidade)
        {
            try
            {
                this.aTbVeiculoDAO.Alterar(pVeiculoEntidade);
            }
            catch (Exception ex)
            {
                throw new Exception("alterar o registro");
            }
            finally
            {
                Conexao.CloseConnection();
            }
        }

        public void Excluir(VeiculoEntidade pVeiculoEntidade)
        {
            try
            {
                this.aTbVeiculoDAO.Excluir(pVeiculoEntidade);
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