using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEscola
{
    public class Avaliacao
    {
        private int id;
        private Aluno aluno;
        private Disciplina disciplina;
        public float nota;

        public Avaliacao() { }

        public Avaliacao(int id, Aluno aluno, Disciplina disciplina, float nota)
        {
            this.ID = id;
            this.Aluno = aluno;
            this.Disciplina = disciplina;
            this.Nota = nota;
        }

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public Aluno Aluno
        {
            get { return this.aluno; }
            set { this.aluno = value; }
        }

        public Disciplina Disciplina
        {
            get { return this.disciplina; }
            set { this.disciplina = value; }
        }

        public float Nota
        {
            get { return this.nota; }
            set { this.nota = value; }
        }
    }
}
