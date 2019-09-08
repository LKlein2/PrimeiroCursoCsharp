using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    public class Almoxarifado
    {
        private int id;
        private string descricao;
        private string nomeResponsavel;
        private CentroCusto centroCusto;

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

        public CentroCusto CentroCusto
        {
            get { return this.centroCusto; }
            set { this.centroCusto = value; }
        }

        public Almoxarifado() { }
        public Almoxarifado(int id, string descricao, string nomeResponsavel, CentroCusto centroCusto)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.NomeResponsavel = nomeResponsavel;
            this.CentroCusto = centroCusto;
        }
    }
}
