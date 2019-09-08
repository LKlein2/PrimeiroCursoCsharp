using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Automovel : Veiculo
    {
        private short portas;
        public short Portas
        {
            get { return portas; }
            set { this.portas = value; }
        }

        public Automovel() { }
        public Automovel(string nome, int ano, short portas) : base(nome, ano)
        {
            this.Portas = portas;
        }

    }
}
