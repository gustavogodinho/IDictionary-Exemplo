using System;
using System.Collections.Generic;

namespace IDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacao[] operacoes = {
                new Operacao(2, "200", -100.00),
                new Operacao(3, "100",100.00),
                new Operacao(4, "300",300.00),
                new Operacao(1, "100",300.00),
                new Operacao(7, "400", 400.00),
                new Operacao(6,"100", -300.00),
                new Operacao(5, "200", 3000.00)
            };


            ApuracaoOperacao apuracao = new ApuracaoOperacao();


            Operacao[] operacoesOrdenadas = apuracao.ListaOrdenada(operacoes);


            IDictionary<string,List<Operacao>> operacoesAgrupadas = apuracao.AgruparPorIdentificador(operacoesOrdenadas);

            foreach (var item in operacoesAgrupadas)
            {
                Console.WriteLine();
            }

            IDictionary<string, double> operacoesSumarizadas = apuracao.SumarizarPorIdentificador(operacoesOrdenadas);

            foreach (var item in operacoesSumarizadas)
            {
                Console.WriteLine();
            }

        }

    }
}
