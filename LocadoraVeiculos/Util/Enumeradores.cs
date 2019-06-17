namespace Util
{
    public static class Enumeradores
    {
        public enum EnumEstadoForm
        {
            CADASTRO
            ,ALTERACAO
            ,CONSULTA
            ,EXCLUSAO
        }

        public enum EnumFormaPagamento
        {
            DINHEIRO = 1
            ,CARTAO_CREDITO = 2
            ,CHEQUE = 3
        }

        public enum EnumEstadoVeiculo
        {
            DISPONIVEL = 1
            ,RESERVADO = 2
            ,ALUGADO = 3
        }

    }
}