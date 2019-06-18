using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DAO;

namespace Model
{
    public class ClienteEntidade
    {
        private static ClienteDAO aClienteDAO = new ClienteDAO();
        private static EnderecoDAO aEnderecoDAO = new EnderecoDAO();

        public ClienteEntidade()
        {
            vEnderecoEntidade = new EnderecoEntidade();
        }

        public int iId { get; set; }
        public string vNome { get; set; }
        public string vCpf { get; set; }
        public short iIdade { get; set; }
        public string vTelefone { get; set; }
        public string vEmail { get; set; }
        public string vCelular { get; set; }
        public string vSexo { get; set; }
        public DateTime dtDataCadastro { get; set; }
        public EnderecoEntidade vEnderecoEntidade { get; set; }

        public string vNomeECpf
        {
            get
            {
                return vNome + " - " + vCpf;
            }
        }

        private static ClienteEntidade MontarObjeto(SqlDataReader pSqlDataReader)
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

            vEnderecoEntidade.iId = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iIdEndereco"], DBNull.Value)) ? pSqlDataReader["iIdEndereco"] : 0);

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

        public static List<ClienteEntidade> Consultar(ClienteEntidade pClienteEntidade)
        {
            List<ClienteEntidade> vListClienteEntidade = new List<ClienteEntidade>();
            try
            {
                SqlDataReader vSqlDataReader = aClienteDAO.Consultar(pClienteEntidade);
                while (vSqlDataReader.Read())
                {
                    vListClienteEntidade.Add(MontarObjeto(vSqlDataReader));
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

        public static List<ClienteEntidade> Consultar()
        {
            return Consultar(new ClienteEntidade());
        }

        public void Salvar()
        {
            try
            {
                if (iId == 0)
                {
                    this.iId = aClienteDAO.Incluir(this);
                    this.vEnderecoEntidade.iIdTbCliente = this.iId;
                    this.vEnderecoEntidade.iId = aEnderecoDAO.Incluir(this.vEnderecoEntidade);
                }
                else
                {
                    aClienteDAO.Alterar(this);
                    aEnderecoDAO.Alterar(this.vEnderecoEntidade);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("salvar o registro");
            }
            finally
            {
                Conexao.CloseConnection();
            }
        }

        public void Excluir()
        {
            try
            {

                aEnderecoDAO.Excluir(this.vEnderecoEntidade);
                aClienteDAO.Excluir(this);
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