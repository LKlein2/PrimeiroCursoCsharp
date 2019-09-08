using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEscola
{
    public class Aluno
    {
        private int id;
        private string nome;

        public Aluno() { }

        public Aluno(int id, string nome)
        {
            this.ID = id;
            this.Nome = nome;
        }

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
    }
}
