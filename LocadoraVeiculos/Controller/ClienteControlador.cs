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
        private ClienteDAO aTbClienteDAO;

        public ClienteControlador()
        {
            this.aTbClienteDAO = new ClienteDAO();
        }

        private ClienteEntidade fnMontarObjeto(SqlDataReader pSqlDataReader)
        {
            ClienteEntidade vClienteEntidade = new ClienteEntidade();

            vClienteEntidade.iId = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iId"], DBNull.Value)) ? pSqlDataReader["iId"] : 0);

            vClienteEntidade.vNome = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vNome"], DBNull.Value)) ? pSqlDataReader["vNome"] : string.Empty);

            vClienteEntidade.vCpf = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vCpf"], DBNull.Value)) ? pSqlDataReader["vCpf"] : string.Empty);

            vClienteEntidade.iIdade = Convert.ToInt16((!object.ReferenceEquals(pSqlDataReader["iIdade"], DBNull.Value)) ? pSqlDataReader["iIdade"] : 0);

            vClienteEntidade.vTelefone = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vTelefone"], DBNull.Value)) ? pSqlDataReader["vTelefone"] : string.Empty);

            vClienteEntidade.vEmail = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vEmail"], DBNull.Value)) ? pSqlDataReader["vEmail"] : string.Empty);

            vClienteEntidade.vCelular = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vCelular"], DBNull.Value)) ? pSqlDataReader["vCelular"] : string.Empty);

            vClienteEntidade.vSexo = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vSexo"], DBNull.Value)) ? pSqlDataReader["vSexo"] : string.Empty);

            vClienteEntidade.dtDataCadastro = Convert.ToDateTime((!object.ReferenceEquals(pSqlDataReader["dtDataCadastro"], DBNull.Value)) ? pSqlDataReader["dtDataCadastro"] : DateTime.MinValue);

            return vClienteEntidade;
        }

        public List<ClienteEntidade> Consultar(ClienteEntidade pClienteEntidade)
        {
            List<ClienteEntidade> vListClienteEntidade = new List<ClienteEntidade>();
            try
            {
                SqlDataReader vSqlDataReader = this.aTbClienteDAO.Consultar(pClienteEntidade);
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
                pClienteEntidade.iId = this.aTbClienteDAO.Incluir(pClienteEntidade);
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
                this.aTbClienteDAO.Alterar(pClienteEntidade);
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
                this.aTbClienteDAO.Excluir(pClienteEntidade);
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