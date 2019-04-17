using System;
using System.Data.Common;
using System.Collections.Generic;
using Model;
using LocadoraVeiculos.DAO;
using System.Data.SqlClient;

namespace Controller
{
    public class ClienteControlador
    {
        private ClienteDAO aClienteDAO;
        private EnderecoDAO aEnderecoDAO;

        public ClienteControlador()
        {
            this.aClienteDAO = new ClienteDAO();
            this.aEnderecoDAO = new EnderecoDAO();
        }

        private ClienteEntidade fnMontarObjeto(SqlDataReader pSqlDataReader)
        {
            ClienteEntidade vClienteEntidade = new ClienteEntidade();
            EnderecoEntidade vEnderecoEntidade = new EnderecoEntidade();

            vClienteEntidade.iId = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iId"], DBNull.Value)) ? pSqlDataReader["iId"] : 0);

            vClienteEntidade.vNome = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vNome"], DBNull.Value)) ? pSqlDataReader["vNome"] : string.Empty);

            vClienteEntidade.vCpf = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vCpf"], DBNull.Value)) ? pSqlDataReader["vCpf"] : string.Empty);

            vClienteEntidade.iIdade = Convert.ToInt16((!object.ReferenceEquals(pSqlDataReader["iIdade"], DBNull.Value)) ? pSqlDataReader["iIdade"] : 0);

            vClienteEntidade.vTelefone = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vTelefone"], DBNull.Value)) ? pSqlDataReader["vTelefone"] : string.Empty);

            vClienteEntidade.vEmail = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vEmail"], DBNull.Value)) ? pSqlDataReader["vEmail"] : string.Empty);

            vClienteEntidade.vCelular = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vCelular"], DBNull.Value)) ? pSqlDataReader["vCelular"] : string.Empty);

            vClienteEntidade.vSexo = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vSexo"], DBNull.Value)) ? pSqlDataReader["vSexo"] : string.Empty);

            vClienteEntidade.dtDataCadastro = Convert.ToDateTime((!object.ReferenceEquals(pSqlDataReader["dtDataCadastro"], DBNull.Value)) ? pSqlDataReader["dtDataCadastro"] : DateTime.MinValue);

            vEnderecoEntidade.iId = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iId"], DBNull.Value)) ? pSqlDataReader["iId"] : 0);

            vEnderecoEntidade.vLogradouro = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vLogradouro"], DBNull.Value)) ? pSqlDataReader["vLogradouro"] : string.Empty);

            vEnderecoEntidade.iNumero = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iNumero"], DBNull.Value)) ? pSqlDataReader["iNumero"] : 0);

            vEnderecoEntidade.vComplemento = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vComplemento"], DBNull.Value)) ? pSqlDataReader["vComplemento"] : string.Empty);

            vEnderecoEntidade.vBairro = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vBairro"], DBNull.Value)) ? pSqlDataReader["vBairro"] : string.Empty);

            vEnderecoEntidade.vCidade = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vCidade"], DBNull.Value)) ? pSqlDataReader["vCidade"] : string.Empty);

            vEnderecoEntidade.vEstado = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vEstado"], DBNull.Value)) ? pSqlDataReader["vEstado"] : string.Empty);

            vEnderecoEntidade.vCep = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vCep"], DBNull.Value)) ? pSqlDataReader["vCep"] : string.Empty);

            vEnderecoEntidade.vObs = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vObs"], DBNull.Value)) ? pSqlDataReader["vObs"] : string.Empty);

            vEnderecoEntidade.iIdTbCliente = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iIdTbCliente"], DBNull.Value)) ? pSqlDataReader["iIdTbCliente"] : 0);

            vClienteEntidade.vEnderecoEntidade = vEnderecoEntidade;

            return vClienteEntidade;
        }

        public List<ClienteEntidade> Consultar(ClienteEntidade pClienteEntidade)
        {
            List<ClienteEntidade> vListClienteEntidade = new List<ClienteEntidade>();
            try
            {
                SqlDataReader vSqlDataReader = this.aClienteDAO.Consultar(pClienteEntidade);
                while (vSqlDataReader.Read())
                {
                    vListClienteEntidade.Add(this.fnMontarObjeto(vSqlDataReader));
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

            return vListClienteEntidade;
        }

        public ClienteEntidade Incluir(ClienteEntidade pClienteEntidade)
        {
            try
            {
                pClienteEntidade.iId = 0;
                pClienteEntidade.iId = this.aClienteDAO.Incluir(pClienteEntidade);
                pClienteEntidade.vEnderecoEntidade.iId = this.aEnderecoDAO.Incluir(pClienteEntidade.vEnderecoEntidade);

                return pClienteEntidade;
            }
            catch (Exception ex)
            {
                throw new Exception("incluir o registro");
            }
        }

        public void Alterar(ClienteEntidade pClienteEntidade)
        {
            try
            {
                this.aClienteDAO.Alterar(pClienteEntidade);
                this.aEnderecoDAO.Alterar(pClienteEntidade.vEnderecoEntidade);
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


        public void Excluir(ClienteEntidade pClienteEntidade)
        {
            try
            {
                this.aEnderecoDAO.Excluir(pClienteEntidade.vEnderecoEntidade);
                this.aClienteDAO.Excluir(pClienteEntidade);
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