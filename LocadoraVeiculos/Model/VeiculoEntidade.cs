using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DAO;

namespace Model
{
    public class VeiculoEntidade
    {
        private static VeiculoDAO aTbVeiculoDAO;

        public VeiculoEntidade()
        {
            aTbVeiculoDAO = new VeiculoDAO();
            vMontadoraEntidade = new MontadoraEntidade();
        }

        public int iId { get; set; }
        public MontadoraEntidade vMontadoraEntidade { get; set; }
        public string vModelo { get; set; }
        public int iAnoFabricacao { get; set; }
        public string vCor { get; set; }
        public decimal dValorLocacao { get; set; }
        public string vPlaca { get; set; }
        public bool bAlugado { get; set; }
        public long iQuilometragem { get; set; }


        public string vNomeMontadora
        {
            get
            {
                return vMontadoraEntidade.vNome;
            }
        }

        public string vModeloEPlaca
        {
            get
            {
                return vModelo + " - " + vPlaca;
            }
        }

        public string bDisponivel
        {
            get
            {
                if(this.bAlugado)
                {
                    return "Não";
                }
                else
                {
                    return "Sim";
                }
            }
        }

        private static VeiculoEntidade MontarObjeto(SqlDataReader pSqlDataReader)
        {
            VeiculoEntidade vVeiculoEntidade = new VeiculoEntidade();

            vVeiculoEntidade.iId = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iId"], DBNull.Value)) ? pSqlDataReader["iId"] : 0);

            vVeiculoEntidade.vMontadoraEntidade.iId = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iIdMontadora"], DBNull.Value)) ? pSqlDataReader["iIdMontadora"] : 0);

            vVeiculoEntidade.vModelo = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vModelo"], DBNull.Value)) ? pSqlDataReader["vModelo"] : string.Empty);

            vVeiculoEntidade.iAnoFabricacao = Convert.ToInt32((!object.ReferenceEquals(pSqlDataReader["iAnoFabricacao"], DBNull.Value)) ? pSqlDataReader["iAnoFabricacao"] : 0);

            vVeiculoEntidade.vCor = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vCor"], DBNull.Value)) ? pSqlDataReader["vCor"] : string.Empty);

            vVeiculoEntidade.dValorLocacao = Convert.ToDecimal((!object.ReferenceEquals(pSqlDataReader["dValorLocacao"], DBNull.Value)) ? pSqlDataReader["dValorLocacao"] : 0);

            vVeiculoEntidade.vPlaca = Convert.ToString((!object.ReferenceEquals(pSqlDataReader["vPlaca"], DBNull.Value)) ? pSqlDataReader["vPlaca"] : string.Empty);

            vVeiculoEntidade.bAlugado = Convert.ToBoolean((!object.ReferenceEquals(pSqlDataReader["bAlugado"], DBNull.Value)) ? pSqlDataReader["bAlugado"] : false);

            vVeiculoEntidade.iQuilometragem = Convert.ToInt64((!object.ReferenceEquals(pSqlDataReader["iQuilometragem"], DBNull.Value)) ? pSqlDataReader["iQuilometragem"] : 0);

            return vVeiculoEntidade;
        }

        public static List<VeiculoEntidade> Consultar(VeiculoEntidade pVeiculoEntidade, bool pApenasDisponiveis)
        {
            List<VeiculoEntidade> vListVeiculoEntidade = new List<VeiculoEntidade>();
            try
            {
                SqlDataReader vSqlDataReader = aTbVeiculoDAO.Consultar(pVeiculoEntidade, pApenasDisponiveis);
                while (vSqlDataReader.Read())
                {
                    VeiculoEntidade vVeiculoEntidade = MontarObjeto(vSqlDataReader);
                    vListVeiculoEntidade.Add(vVeiculoEntidade);
                }

                //Fecha a conexao para consultar as montadoras
                Conexao.CloseConnection();

                foreach (var vVeiculoEntidade in vListVeiculoEntidade)
                {
                    vVeiculoEntidade.vMontadoraEntidade = (MontadoraEntidade.Consultar(vVeiculoEntidade.vMontadoraEntidade))[0];
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

        public void Salvar()
        {
            try
            {
                if (iId == 0)
                {
                    this.iId = aTbVeiculoDAO.Incluir(this);
                }
                else
                {
                    aTbVeiculoDAO.Alterar(this);
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
                aTbVeiculoDAO.Excluir(this);
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