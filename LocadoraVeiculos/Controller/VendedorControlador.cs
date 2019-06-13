using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Model;
using DAO;

namespace Controller
{
    public class VendedorControlador : UsuarioControlador
    {
        private VendedorDAO aTbVendedorDAO;

        public VendedorControlador()
        {
            this.aTbVendedorDAO = new VendedorDAO();
        }

        private VendedorEntidade fnMontarObjeto(SqlDataReader pSqlDataReader)
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


        public override List<UsuarioEntidade> Consultar(UsuarioEntidade pUsuarioEntidade)
        {
            List<UsuarioEntidade> vListUsuarioEntidade = new List<UsuarioEntidade>();

            UsuarioEntidade v = new VendedorEntidade();

            VendedorEntidade vVendedorEntidade = (VendedorEntidade)pUsuarioEntidade;
            try
            {
                SqlDataReader vSqlDataReader = this.aTbVendedorDAO.Consultar(vVendedorEntidade);
                while (vSqlDataReader.Read())
                {
                    vListUsuarioEntidade.Add((VendedorEntidade)this.fnMontarObjeto(vSqlDataReader));
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

            return vListUsuarioEntidade;
        }

        public VendedorEntidade Incluir(VendedorEntidade pVendedorEntidade)
        {
            try
            {
                pVendedorEntidade.iId = 0;
                pVendedorEntidade.iId = this.aTbVendedorDAO.Incluir(pVendedorEntidade);
                return pVendedorEntidade;
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

        public void Alterar(VendedorEntidade pVendedorEntidade)
        {
            try
            {
                this.aTbVendedorDAO.Alterar(pVendedorEntidade);
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

        public void Excluir(VendedorEntidade pVendedorEntidade)
        {
            try
            {
                this.aTbVendedorDAO.Excluir(pVendedorEntidade);
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