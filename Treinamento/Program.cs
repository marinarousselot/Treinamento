using System;

namespace Treinamento
{
    class Program
    {
        static void Main(string[] args)
        {
            var hoje = DateTime.Now.Date;

            var pagamentos = new Pagamento[]
            {
                new PagamentoBoleto
                {
                    DataVencimento = hoje.AddDays(10),
                    LinhaDigitavel = "123",
                    Valor = 123.45
                },
new PagamentoFiado
                {
                    DataVencimento = hoje.AddDays(30),
                    Consumos = new PagamentoFiadoConsumo[]
                    {
                        new PagamentoFiadoConsumo
                        {
                            Descricao = "Coca-cola",
                            Quantidade = 2,
                            ValorUnitario = 5.5
                        },
                        new PagamentoFiadoConsumo
                        {

}
            };
        }
    }
}
