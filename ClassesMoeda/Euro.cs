using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMoeda
{
    public class Euro : Moeda
    {
        public Euro(string nome, double valor, double cotacao) : base(nome, valor, cotacao) { }

        public override double valorEmReais()
        {
            return this.Valor * this.Cotacao * 1.1;
        }
    }
}
