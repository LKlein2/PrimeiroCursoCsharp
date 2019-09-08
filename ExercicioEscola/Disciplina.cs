using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEscola
{
    public class Disciplina
    {
        private int id;
        private string nome;
        private int mediaParaAprovacao;

        public Disciplina() { }
        public Disciplina(int id, string nome, int mediaParaAprovacao)
        {
            this.ID = id;
            this.Nome = nome;
            this.MediaParaAprovacao = mediaParaAprovacao;
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

        public int MediaParaAprovacao
        {
            get { return this.mediaParaAprovacao; }
            set { this.mediaParaAprovacao = value; }
        }
    }
}
