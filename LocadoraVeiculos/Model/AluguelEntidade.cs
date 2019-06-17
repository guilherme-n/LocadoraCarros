using System;
using System.Collections.Generic;
using System.Data.Common;
using DAO;

namespace Model
{
    public class AluguelEntidade
    {
        private static AluguelDAO aAluguelDAO = new AluguelDAO();

        public int iId { get; set; }
        public MontadoraEntidade vMontadoraEntidade { get; set; }
        public VeiculoEntidade vVeiculoEntidade { get; set; }
        public ClienteEntidade vClienteEntidade { get; set; }
        public int iQtdDiarias { get; set; }
        public decimal dValorTotal { get; set; }
        public int iIdTbFormaPagamento { get; set; }
        public DateTime dtDataInicioAluguel { get; set; }
        public DateTime dtDataOperacao { get; set; }
        public VendedorEntidade vVendedorEntidade { get; set; }
        public DateTime dtDataDevolucao { get; set; }

        public string vModeloEPlaca
        {
            get
            {
                return vVeiculoEntidade.vModeloEPlaca;
            }
        }

        public DateTime dtDataEntrega
        {
            get
            {
                return dtDataInicioAluguel.AddDays(iQtdDiarias);
            }
        }

        public string vCliente
        {
            get
            {
                return vClienteEntidade.vNomeECpf;
            }
        }

        public AluguelEntidade()
        {
            vMontadoraEntidade = new MontadoraEntidade();
            vVeiculoEntidade = new VeiculoEntidade();
            vClienteEntidade = new ClienteEntidade();
            vVendedorEntidade = new VendedorEntidade();
        }

        private static AluguelEntidade MontarObjeto(DbDataReader pDbDataReader)
        {
            AluguelEntidade vAluguelEntidade = new AluguelEntidade();

            vAluguelEntidade.iId = Convert.ToInt32((!object.ReferenceEquals(pDbDataReader["iId"], DBNull.Value)) ? pDbDataReader["iId"] : 0);

            vAluguelEntidade.vMontadoraEntidade.iId = Convert.ToInt32((!object.ReferenceEquals(pDbDataReader["iIdTbMontadora"], DBNull.Value)) ? pDbDataReader["iIdTbMontadora"] : 0);

            vAluguelEntidade.vVeiculoEntidade.iId = Convert.ToInt32((!object.ReferenceEquals(pDbDataReader["iIdTbVeiculo"], DBNull.Value)) ? pDbDataReader["iIdTbVeiculo"] : 0);

            vAluguelEntidade.vClienteEntidade.iId = Convert.ToInt32((!object.ReferenceEquals(pDbDataReader["iIdTbCliente"], DBNull.Value)) ? pDbDataReader["iIdTbCliente"] : 0);

            vAluguelEntidade.iQtdDiarias = Convert.ToInt32((!object.ReferenceEquals(pDbDataReader["iQtdDiarias"], DBNull.Value)) ? pDbDataReader["iQtdDiarias"] : 0);

            vAluguelEntidade.dValorTotal = Convert.ToDecimal((!object.ReferenceEquals(pDbDataReader["dValorTotal"], DBNull.Value)) ? pDbDataReader["dValorTotal"] : 0);

            vAluguelEntidade.iIdTbFormaPagamento = Convert.ToInt32((!object.ReferenceEquals(pDbDataReader["iIdTbFormaPagamento"], DBNull.Value)) ? pDbDataReader["iIdTbFormaPagamento"] : 0);

            vAluguelEntidade.dtDataInicioAluguel = Convert.ToDateTime((!object.ReferenceEquals(pDbDataReader["dtDataInicioAluguel"], DBNull.Value)) ? pDbDataReader["dtDataInicioAluguel"] : DateTime.MinValue);

            vAluguelEntidade.dtDataOperacao = Convert.ToDateTime((!object.ReferenceEquals(pDbDataReader["dtDataOperacao"], DBNull.Value)) ? pDbDataReader["dtDataOperacao"] : DateTime.MinValue);

            vAluguelEntidade.vVendedorEntidade.iId = Convert.ToInt32((!object.ReferenceEquals(pDbDataReader["iIdTbVendedor"], DBNull.Value)) ? pDbDataReader["iIdTbVendedor"] : 0);

            vAluguelEntidade.dtDataDevolucao = Convert.ToDateTime((!object.ReferenceEquals(pDbDataReader["dtDataDevolucao"], DBNull.Value)) ? pDbDataReader["dtDataDevolucao"] : DateTime.MinValue);

            return vAluguelEntidade;
        }

        private static List<AluguelEntidade> MontarAluguelEntidade (DbDataReader pDbDataReader)
        {
            List<AluguelEntidade> vListAluguelEntidade = new List<AluguelEntidade>();
            try
            {                
                while (pDbDataReader.Read())
                {
                    vListAluguelEntidade.Add(MontarObjeto(pDbDataReader));
                }

                //Fecha a conexao para consultar os veiculos
                Conexao.CloseConnection();

                foreach (var vAluguelEntidade in vListAluguelEntidade)
                {
                    vAluguelEntidade.vVeiculoEntidade = (VeiculoEntidade.Consultar(vAluguelEntidade.vVeiculoEntidade))[0];
                }

                //Fecha a conexao para consultar os clientes
                Conexao.CloseConnection();

                foreach (var vAluguelEntidade in vListAluguelEntidade)
                {
                    vAluguelEntidade.vClienteEntidade = (ClienteEntidade.Consultar(vAluguelEntidade.vClienteEntidade))[0];
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
            return vListAluguelEntidade;
        }

        public static List<AluguelEntidade> Consultar(AluguelEntidade pAluguelEntidade)
        {
            DbDataReader vDbDataReader = aAluguelDAO.Consultar(pAluguelEntidade);

            return MontarAluguelEntidade(vDbDataReader);
        }

        public static List<AluguelEntidade> Consultar()
        {
            return Consultar(new AluguelEntidade());
        }

        public static List<AluguelEntidade> Consultar(bool pApenasDisponiveis)
        {
            DbDataReader vDbDataReader = aAluguelDAO.Consultar(pApenasDisponiveis);

            return MontarAluguelEntidade(vDbDataReader);
        }

        public void Salvar()
        {
            try
            {
                if (iId == 0)
                {
                    this.iId = aAluguelDAO.Incluir(this);
                }
                else
                {
                    aAluguelDAO.Alterar(this);
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

        public void DevolverVeiculo()
        {
            aAluguelDAO.DevolverVeiculo(this);
        }

        public void Excluir(AluguelEntidade pAluguelEntidade)
        {
            try
            {
                aAluguelDAO.Excluir(pAluguelEntidade);
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