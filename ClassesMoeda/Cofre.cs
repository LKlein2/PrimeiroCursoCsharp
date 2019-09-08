using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMoeda
{
    public class Cofre : List<Moeda>
    {
        private double valorFinal;

        public double ValorFinal
        {
            get { return this.valorFinal; }
        }
        public void ValorAcumuladoEmReais()
        {
            this.valorFinal = 0;
            foreach (Moeda moeda in this)
            {
                this.valorFinal += moeda.valorEmReais();
            }
        }


    }
}
