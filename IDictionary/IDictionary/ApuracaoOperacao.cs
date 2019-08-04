using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDictionary
{
    class ApuracaoOperacao
    {
        public Operacao[] ListaOrdenada(Operacao[] operacoes)
        {
            
            try
            {
                Operacao[] operacaoSort = operacoes.OrderBy(oper => oper.Id).ToArray();

                return operacaoSort;
            }
            catch (Exception)
            {

                throw;
            }

           
        }

        public IDictionary<string, List<Operacao>> AgruparPorIdentificador(IEnumerable<Operacao> operacoes)
        {
            IDictionary<string, List<Operacao>> retorno = new Dictionary<string, List<Operacao>>();

            foreach (var item in operacoes)
            {
                if (retorno.ContainsKey(item.Identificador))
                {
                    retorno[item.Identificador].Add(item);
                }
                else
                {
                    retorno.Add(item.Identificador, new List<Operacao>() { item });
                }
            }

            return retorno;
        }

        public IDictionary<string, double> SumarizarPorIdentificador(IEnumerable<Operacao> operacoes)
        {

            IDictionary<string, double> retorno = new Dictionary<string, double>();

            foreach (var item in operacoes)
            {
                if (retorno.ContainsKey(item.Identificador))
                {
                    retorno[item.Identificador] += item.Valor;
                }
                else
                {
                    retorno.Add(item.Identificador, item.Valor);
                }

            }

            return retorno;
        }
    }
}
