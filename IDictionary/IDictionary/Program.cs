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

            Console.WriteLine("Ordenado:");

            foreach (Operacao item in operacoesOrdenadas)
            {
                Console.WriteLine("{0} {1} {2}", item.Id, item.Identificador, item.Valor);
            }

            Console.WriteLine("----------");

            IDictionary<string, List<Operacao>> operacoesAgrupadas = apuracao.AgruparPorIdentificador(operacoesOrdenadas);

            foreach (KeyValuePair<string, List<Operacao>> item in operacoesAgrupadas)
            {
                Console.WriteLine($"Existem {item.Value.Count} operações de identificador {item.Key}.");
            }

            IDictionary<string, double> operacoesSumarizadas = apuracao.SumarizarPorIdentificador(operacoesOrdenadas);

            foreach (KeyValuePair<string, double> item in operacoesSumarizadas)
            {
                Console.WriteLine($"Soma das operações de identificador {item.Key} é {item.Value}.");
            }

        }

    }
}
