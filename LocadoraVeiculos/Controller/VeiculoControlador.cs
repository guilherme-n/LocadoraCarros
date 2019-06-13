using System;
using System.Collections.Generic;
using Model;
using DAO;
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

            vVeiculoEntidade.vMontadoraEntidade.iId= Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iIdMontadora"], DBNull.Value)) ? pSqlDataReader["iIdMontadora"] : 0);

            vVeiculoEntidade.vModelo = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vModelo"], DBNull.Value)) ? pSqlDataReader["vModelo"] : string.Empty);

            vVeiculoEntidade.iAnoFabricacao = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iAnoFabricacao"], DBNull.Value)) ? pSqlDataReader["iAnoFabricacao"] : 0);

            vVeiculoEntidade.iQtd = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iQtd"], DBNull.Value)) ? pSqlDataReader["iQtd"] : 0);

            vVeiculoEntidade.iQtdDisponivel = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iQtdDisponivel"], DBNull.Value)) ? pSqlDataReader["iQtdDisponivel"] : 0);

            vVeiculoEntidade.vCor = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vCor"], DBNull.Value)) ? pSqlDataReader["vCor"] : string.Empty);

            return vVeiculoEntidade;
        }

        public List<VeiculoEntidade> Consultar(VeiculoEntidade pVeiculoEntidade, bool pApenasDisponiveis)
        {
            List<VeiculoEntidade> vListVeiculoEntidade = new List<VeiculoEntidade>();
            try
            {
                SqlDataReader vSqlDataReader = this.aTbVeiculoDAO.Consultar(pVeiculoEntidade, pApenasDisponiveis);
                while (vSqlDataReader.Read())
                {
                    VeiculoEntidade vVeiculoEntidade = this.fnMontarObjeto(vSqlDataReader);
                    vListVeiculoEntidade.Add(vVeiculoEntidade);                    
                }

                //Fecha a conexao para consultar as montadoras
                Conexao.CloseConnection();

                foreach (var vVeiculoEntidade in vListVeiculoEntidade)
                {
                    vVeiculoEntidade.vMontadoraEntidade = (new MontadoraControlador().Consultar(vVeiculoEntidade.vMontadoraEntidade))[0];
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