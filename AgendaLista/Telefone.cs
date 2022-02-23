using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaLista
{
    internal class Telefone
    {
        public string Ddd { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }
        public Telefone Proximo { get; set; }

        public Telefone(string tipo, string ddd, string numero)
        {
            Ddd = ddd;
            Numero = numero;
            Tipo = tipo;
            Proximo = null;
        }

        public override string ToString()
        {
            return "" + Tipo + ": (" + Ddd + "): " + Numero;
        }
    }
}
