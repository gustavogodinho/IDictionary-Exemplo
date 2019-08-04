using System;
using System.Collections.Generic;
using System.Text;

namespace IDictionary
{
    class Operacao
    {
        public Operacao(int id, string identificador, double valor)
        {
            Id = id;
            Identificador = identificador ?? throw new ArgumentNullException(nameof(identificador));
            Valor = valor;
        }

        public int Id { get; set; }
        public string Identificador { get; private set; }
        public double Valor { get; set; }

    }
}
