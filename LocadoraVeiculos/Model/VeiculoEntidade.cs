using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DAO;
using Util;

namespace Model
{
    public class VeiculoEntidade
    {
        private static VeiculoDAO aTbVeiculoDAO = new VeiculoDAO();

        public VeiculoEntidade()
        {            
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
        public Enumeradores.EnumEstadoVeiculo iEstadoVeiculo { get; set; }


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

        public string vEstado
        {
            get
            {
                string vEstadoAux = iEstadoVeiculo.ToString();
                return (vEstadoAux.Substring(0, 1).ToUpper() + vEstadoAux.Substring(1).ToLower());
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

            vVeiculoEntidade.iQuilometragem = Convert.ToInt64((!object.ReferenceEquals(pSqlDataReader["iQuilometragem"], DBNull.Value)) ? pSqlDataReader["iQuilometragem"] : 0);

            vVeiculoEntidade.iEstadoVeiculo = (Enumeradores.EnumEstadoVeiculo)Convert.ToInt64((!object.ReferenceEquals(pSqlDataReader["iEstadoVeiculo"], DBNull.Value)) ? pSqlDataReader["iEstadoVeiculo"] : 0);

            return vVeiculoEntidade;
        }

        public static List<VeiculoEntidade> Consultar(VeiculoEntidade pVeiculoEntidade)
        {
            List<VeiculoEntidade> vListVeiculoEntidade = new List<VeiculoEntidade>();
            try
            {
                SqlDataReader vSqlDataReader = aTbVeiculoDAO.Consultar(pVeiculoEntidade);
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

        public static List<VeiculoEntidade> Consultar()
        {
            return Consultar(new VeiculoEntidade());
        }

        public static List<VeiculoEntidade> Consultar(Enumeradores.EnumEstadoVeiculo pEstadoVeiculo)
        {
            List<VeiculoEntidade> vListVeiculoEntidade = new List<VeiculoEntidade>();
            try
            {
                SqlDataReader vSqlDataReader = aTbVeiculoDAO.Consultar(pEstadoVeiculo);
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

        public static List<VeiculoEntidade> Consultar(bool pAlugados)
        {
            List<VeiculoEntidade> vListVeiculoEntidade = new List<VeiculoEntidade>();
            try
            {
                SqlDataReader vSqlDataReader = aTbVeiculoDAO.Consultar(pAlugados);
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

        public void Carregar()
        {
            try
            {
                if (iId == 0)
                {
                    throw new Exception("não informar o ID");
                }

                SqlDataReader vSqlDataReader = aTbVeiculoDAO.Consultar(this);
                vSqlDataReader.Read();
                VeiculoEntidade vVeiculoEntidade = MontarObjeto(vSqlDataReader);

                this.vMontadoraEntidade = vVeiculoEntidade.vMontadoraEntidade;
                this.vModelo = vVeiculoEntidade.vModelo;
                this.iAnoFabricacao = vVeiculoEntidade.iAnoFabricacao;
                this.vCor = vVeiculoEntidade.vCor;
                this.dValorLocacao = vVeiculoEntidade.dValorLocacao;
                this.vPlaca = vVeiculoEntidade.vPlaca;
                this.iQuilometragem = vVeiculoEntidade.iQuilometragem;
                this.iEstadoVeiculo = vVeiculoEntidade.iEstadoVeiculo;
            }
            catch (Exception ex)
            {
                throw new Exception("carregar o registro");
            }
            finally
            {
                Conexao.CloseConnection();
            }

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

        public void AlterarEstado(Enumeradores.EnumEstadoVeiculo pEstadoVeiculo)
        {
            try
            { 
                aTbVeiculoDAO.AlterarEstado(this, pEstadoVeiculo);
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