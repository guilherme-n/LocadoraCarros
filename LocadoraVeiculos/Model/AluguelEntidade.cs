using System;
using System.Collections.Generic;
using System.Data.Common;
using DAO;

namespace Model
{
    public class AluguelEntidade
    {
        private static AluguelDAO aAluguelDAO;

        public int iId { get; set; }
        public int iIdTbMontadora { get; set; }
        public int iIdTbVeiculo { get; set; }
        public int iIdTbCliente { get; set; }
        public int iQtdDiarias { get; set; }
        public decimal dValorTotal { get; set; }
        public int iIdTbFormaPagamento { get; set; }
        public DateTime dtDataInicioAluguel { get; set; }
        public DateTime dtDataOperacao { get; set; }

        public AluguelEntidade()
        {
            aAluguelDAO = new AluguelDAO();
        }

        private static AluguelEntidade MontarObjeto(DbDataReader pDbDataReader)
        {
            AluguelEntidade vAluguelEntidade = new AluguelEntidade();

            vAluguelEntidade.iId = Convert.ToInt32((!object.ReferenceEquals(pDbDataReader["iId"], DBNull.Value)) ? pDbDataReader["iId"] : 0);

            vAluguelEntidade.iIdTbMontadora = Convert.ToInt32((!object.ReferenceEquals(pDbDataReader["iIdTbMontadora"], DBNull.Value)) ? pDbDataReader["iIdTbMontadora"] : 0);

            vAluguelEntidade.iIdTbVeiculo = Convert.ToInt32((!object.ReferenceEquals(pDbDataReader["iIdTbVeiculo"], DBNull.Value)) ? pDbDataReader["iIdTbVeiculo"] : 0);

            vAluguelEntidade.iIdTbCliente = Convert.ToInt32((!object.ReferenceEquals(pDbDataReader["iIdTbCliente"], DBNull.Value)) ? pDbDataReader["iIdTbCliente"] : 0);

            vAluguelEntidade.iQtdDiarias = Convert.ToInt32((!object.ReferenceEquals(pDbDataReader["iQtdDiarias"], DBNull.Value)) ? pDbDataReader["iQtdDiarias"] : 0);

            vAluguelEntidade.dValorTotal = Convert.ToDecimal((!object.ReferenceEquals(pDbDataReader["dValorTotal"], DBNull.Value)) ? pDbDataReader["dValorTotal"] : 0);

            vAluguelEntidade.iIdTbFormaPagamento = Convert.ToInt32((!object.ReferenceEquals(pDbDataReader["iIdTbFormaPagamento"], DBNull.Value)) ? pDbDataReader["iIdTbFormaPagamento"] : 0);

            vAluguelEntidade.dtDataInicioAluguel = Convert.ToDateTime((!object.ReferenceEquals(pDbDataReader["dtDataInicioAluguel"], DBNull.Value)) ? pDbDataReader["dtDataInicioAluguel"] : DateTime.MinValue);

            vAluguelEntidade.dtDataOperacao = Convert.ToDateTime((!object.ReferenceEquals(pDbDataReader["dtDataOperacao"], DBNull.Value)) ? pDbDataReader["dtDataOperacao"] : DateTime.MinValue);

            return vAluguelEntidade;
        }

        public static List<AluguelEntidade> Consultar(AluguelEntidade pAluguelEntidade)
        {
            List<AluguelEntidade> vListAluguelEntidade = new List<AluguelEntidade>();
            try
            {
                DbDataReader vDbDataReader = aAluguelDAO.Consultar(pAluguelEntidade);
                while (vDbDataReader.Read())
                {
                    vListAluguelEntidade.Add(MontarObjeto(vDbDataReader));
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