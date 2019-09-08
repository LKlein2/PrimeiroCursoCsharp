using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Biblioteca de classes ->
namespace Classes
{
    public class Veiculo
    {
        private string nome;
        private int ano;

        //PROPRIEDADES == GETTER AND SETTER
        public string Nome
        {
            get { return nome; }
            set { this.nome = value; }
        }
        public int Ano
        {
            get { return ano; }
            set { this.ano = value; }
        }

        //CONSTRUTORES
        public Veiculo()
        {

        }
        public Veiculo(string nome, int ano)
        {
            //ERRADO(direto no atributo):
            //this.nome = nome;
            //this.ano = ano;
            //CERTO(através da propriedade):
            this.Nome = nome;
            this.Ano = ano;
        }

        //DESTRUTORES
        ~Veiculo() {
            //Destrutor, chama quando o garbage colector destroy a instancia.
        }


    }
}
