using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEscola
{
    public class FechamentoAno
    {
        private int id;
        List<Avaliacao> avaliacao;

        public FechamentoAno() { }

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public List<Avaliacao> Avalicao
        {
            get { return this.avaliacao; }
            set { this.avaliacao = value; }
        }

        public List<Aluno> RetornaAprovados()
        {
            return null;
        }


    }
}
