using System;
using System.Data.Common;
using System.Collections.Generic;
using Model;
using LocadoraVeiculos.DAO;
using System.Data.SqlClient;

namespace Controller
{
    public class EnderecoControlador
    {
        private EnderecoDAO aTbEnderecoDAO;

        public EnderecoControlador()
        {
            this.aTbEnderecoDAO = new EnderecoDAO();
        }

        private EnderecoEntidade fnMontarObjeto(SqlDataReader pSqlDataReader)
        {
            EnderecoEntidade vEnderecoEntidade = new EnderecoEntidade();

            vEnderecoEntidade.iId = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iId"], DBNull.Value)) ? pSqlDataReader["iId"] : 0);

            vEnderecoEntidade.vLogradouro = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vLogradouro"], DBNull.Value)) ? pSqlDataReader["vLogradouro"] : string.Empty);

            vEnderecoEntidade.iNumero = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iNumero"], DBNull.Value)) ? pSqlDataReader["iNumero"] : 0);

            vEnderecoEntidade.vComplemento = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vComplemento"], DBNull.Value)) ? pSqlDataReader["vComplemento"] : string.Empty);

            vEnderecoEntidade.vBairro = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vBairro"], DBNull.Value)) ? pSqlDataReader["vBairro"] : string.Empty);

            vEnderecoEntidade.vCidade = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vCidade"], DBNull.Value)) ? pSqlDataReader["vCidade"] : string.Empty);

            vEnderecoEntidade.vEstado = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vEstado"], DBNull.Value)) ? pSqlDataReader["vEstado"] : string.Empty);

            vEnderecoEntidade.vCep = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vCep"], DBNull.Value)) ? pSqlDataReader["vCep"] : string.Empty);

            vEnderecoEntidade.dtDataCriacao = Convert.ToDateTime((!object.ReferenceEquals(pSqlDataReader["dtDataCriacao"], DBNull.Value)) ? pSqlDataReader["dtDataCriacao"] : DateTime.MinValue);

            vEnderecoEntidade.vObs = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vObs"], DBNull.Value)) ? pSqlDataReader["vObs"] : string.Empty);

            vEnderecoEntidade.iIdTbCliente = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iIdTbCliente"], DBNull.Value)) ? pSqlDataReader["iIdTbCliente"] : 0);

            return vEnderecoEntidade;
        }

        public List<EnderecoEntidade> Consultar(EnderecoEntidade pEnderecoEntidade)
        {
            List<EnderecoEntidade> vListEnderecoEntidade = new List<EnderecoEntidade>();
            try
            {
                SqlDataReader vSqlDataReader = this.aTbEnderecoDAO.Consultar(pEnderecoEntidade);
                while (vSqlDataReader.Read())
                {
                    vListEnderecoEntidade.Add(this.fnMontarObjeto(vSqlDataReader));
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

            return vListEnderecoEntidade;
        }

        public EnderecoEntidade Incluir(EnderecoEntidade pEnderecoEntidade)
        {
            try
            {
                pEnderecoEntidade.iId = 0;
                pEnderecoEntidade.iId = this.aTbEnderecoDAO.Incluir(pEnderecoEntidade);
                return pEnderecoEntidade;
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


        public void Alterar(EnderecoEntidade pEnderecoEntidade)
        {
            try
            {
                this.aTbEnderecoDAO.Alterar(pEnderecoEntidade);
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

        public void Excluir(EnderecoEntidade pEnderecoEntidade)
        {
            try
            {
                this.aTbEnderecoDAO.Excluir(pEnderecoEntidade);
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