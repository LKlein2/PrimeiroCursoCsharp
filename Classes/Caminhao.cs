using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    //Sealed nao pode ser herdado, equivalente ao final do java
    public sealed class Caminhao : Automovel
    {
        private int eixos;
        public int Eixos
        {
            get { return this.eixos; }
            set { this.eixos = value; }
        }

        public Caminhao()
        {
            this.Eixos = 2;
        }
        public Caminhao(string nome, int ano, short portas, int eixos) : base(nome, ano, portas)
        {
            this.Nome = nome;
            this.Ano = ano;
            this.Eixos = 2;
        }
    }
}
