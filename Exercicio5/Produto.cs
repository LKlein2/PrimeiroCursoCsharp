using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    public class Produto
    {
        private int id;
        private string descricao;
        private string nomeResponsavel;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }
        public string NomeResponsavel
        {
            get { return this.nomeResponsavel; }
            set { this.nomeResponsavel = value; }
        }
        public Produto() { }
        public Produto(int id, string descricao, string nomeResponsavel)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.NomeResponsavel = nomeResponsavel;
        }
    }
}
