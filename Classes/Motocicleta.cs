using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Motocicleta : Veiculo
    {
        private int cilindrada;
        public int Cilindrada
        {
            get { return this.cilindrada; }
            set { this.cilindrada = value; }
        }
        public Motocicleta() { }
        public Motocicleta(string nome, int ano, int cilindrada) : base(nome, ano)
        {
            this.Cilindrada = cilindrada;
        }
    }
}
