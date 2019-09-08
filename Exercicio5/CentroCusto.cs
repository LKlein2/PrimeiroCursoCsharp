using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    public class CentroCusto
    {
        private int id;
        private string descricao;

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

        public CentroCusto() { }
        public CentroCusto(int id, string descricao)
        {
            this.Id = id;
            this.Descricao = descricao;
        }
    }
}
