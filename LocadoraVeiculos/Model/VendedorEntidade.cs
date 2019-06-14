using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DAO;
using Util;

namespace Model
{
    public class VendedorEntidade : UsuarioEntidade
    {
        private static VendedorDAO aTbVendedorDAO;

        public string vCpf { get; set; }
        public decimal dSalario { get; set; }
        public int iPercentualComissao { get; set; }
        public DateTime dtDataAdmissao { get; set; }
        public DateTime dtDataDemissao { get; set; }

        public VendedorEntidade()
        {
            aTbVendedorDAO = new VendedorDAO();
        }

        private static VendedorEntidade MontarObjeto(SqlDataReader pSqlDataReader)
        {
            VendedorEntidade vVendedorEntidade = new VendedorEntidade();

            vVendedorEntidade.iId = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iId"], DBNull.Value)) ? pSqlDataReader["iId"] : 0);

            vVendedorEntidade.vCpf = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vCpf"], DBNull.Value)) ? pSqlDataReader["vCpf"] : string.Empty);

            vVendedorEntidade.dSalario = Convert.ToDecimal((!object.ReferenceEquals(pSqlDataReader["dSalario"], DBNull.Value)) ? pSqlDataReader["dSalario"] : 0);

            vVendedorEntidade.iPercentualComissao = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iPercentualComissao"], DBNull.Value)) ? pSqlDataReader["iPercentualComissao"] : 0);

            vVendedorEntidade.dtDataAdmissao = Convert.ToDateTime((!object.ReferenceEquals(pSqlDataReader["dtDataAdmissao"], DBNull.Value)) ? pSqlDataReader["dtDataAdmissao"] : DateTime.MinValue);

            vVendedorEntidade.dtDataDemissao = Convert.ToDateTime((!object.ReferenceEquals(pSqlDataReader["dtDataDemissao"], DBNull.Value)) ? pSqlDataReader["dtDataDemissao"] : DateTime.MinValue);

            vVendedorEntidade.vNome = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vNome"], DBNull.Value)) ? pSqlDataReader["vNome"] : string.Empty);

            vVendedorEntidade.vLogin = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vLogin"], DBNull.Value)) ? pSqlDataReader["vLogin"] : string.Empty);

            vVendedorEntidade.vSenha = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vSenha"], DBNull.Value)) ? pSqlDataReader["vSenha"] : string.Empty);

            vVendedorEntidade.bAtivo = Convert.ToBoolean((!object.ReferenceEquals(pSqlDataReader["bAtivo"], DBNull.Value)) ? pSqlDataReader["bAtivo"] : string.Empty);

            return vVendedorEntidade;
        }

        public static List<VendedorEntidade> Consultar()
        {
            return Consultar(new VendedorEntidade());
        }

        public static List<VendedorEntidade> Consultar(VendedorEntidade pVendedorEntidade)
        {
            List<VendedorEntidade> vListVendedorEntidade = new List<VendedorEntidade>();

            VendedorEntidade vVendedorEntidade = pVendedorEntidade;
            try
            {
                SqlDataReader vSqlDataReader = aTbVendedorDAO.Consultar(vVendedorEntidade);
                while (vSqlDataReader.Read())
                {
                    vListVendedorEntidade.Add(MontarObjeto(vSqlDataReader));
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

            return vListVendedorEntidade;
        }

        public void Carregar()
        {
            try
            {
                if(iId == 0)
                {
                    throw new Exception("não informar o ID");
                }

                SqlDataReader vSqlDataReader = aTbVendedorDAO.Consultar(this);
                vSqlDataReader.Read();
                VendedorEntidade vVendedorEntidade = MontarObjeto(vSqlDataReader);

                this.vCpf = vVendedorEntidade.vCpf;
                this.dSalario = vVendedorEntidade.dSalario;
                this.iPercentualComissao = vVendedorEntidade.iPercentualComissao;
                this.dtDataAdmissao = vVendedorEntidade.dtDataAdmissao;
                this.dtDataDemissao = vVendedorEntidade.dtDataDemissao;
                this.vNome = vVendedorEntidade.vNome;
                this.vLogin = vVendedorEntidade.vLogin;
                this.vSenha = vVendedorEntidade.vSenha;
                this.bAtivo = vVendedorEntidade.bAtivo;
            }
            catch (Exception ex)
            {
                throw new Exception("carregar o registro");
            }

        }

        public static UsuarioEntidade ValidarLogin(string pLogin, string pSenha)
        {
            try
            {
                VendedorEntidade vVendedorEntidade = new VendedorEntidade();
                vVendedorEntidade.vLogin = pLogin;
                vVendedorEntidade.vSenha = Utilitarios.GerarHash(pSenha);

                List<VendedorEntidade> vListVendedorEntidade = VendedorEntidade.Consultar(vVendedorEntidade);

                if (vListVendedorEntidade.Count == 0)
                {
                    return null;
                }
                else
                {
                    return vListVendedorEntidade[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("salvar o registro");
            }
        }

        public void AlterarSenha()
        {
            try
            {  
                this.vSenha = Utilitarios.GerarHash(this.vSenha);
                Salvar();
            }
            catch (Exception ex)
            {
                throw new Exception("salvar o registro");
            }
        }

        public void Salvar()
        {
            try
            {
                if(iId == 0)
                {
                    vSenha = Utilitarios.GerarHash(vSenha);
                    iId = aTbVendedorDAO.Incluir(this);
                }
                else
                {
                    aTbVendedorDAO.Alterar(this);
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
                aTbVendedorDAO.Excluir(this);
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