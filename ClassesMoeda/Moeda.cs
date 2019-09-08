using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMoeda
{
    public abstract class Moeda
    {
        private string nome;
        private double valor;
        private double cotacao;

        public Moeda()
        {

        }

        public Moeda(string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }

        public Moeda(string nome, double valor, double cotacao) : this(nome, valor)
        {
            this.Cotacao = cotacao;
        }

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public double Valor
        {
            get { return this.valor; }
            set { this.valor = value; }
        }

        public double Cotacao
        {
            get { return this.cotacao; }
            set { this.cotacao = value; }
        }

        public abstract double valorEmReais();
    }
}
