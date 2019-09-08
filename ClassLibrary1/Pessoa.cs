using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesPessoa
{
    public abstract class Pessoa : IGeradorId, IValida, IDisposable, IComparable
    {
        private DateTime dataCadastro;
        private int id;

        public Pessoa(int id, DateTime dataCadastro)
        {
            this.Id = id;
            this.DataCadastro = dataCadastro;
        }

        public DateTime DataCadastro
        {
            get { return this.dataCadastro; }
            set { this.dataCadastro = value; }
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void GerarId ()
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            this.id = rand.Next(500000);
        }

        public bool valida()
        {
            if (this.DataCadastro != null)
            {
                return true;
            }
            return false;
        }

        public abstract void ValidaDocumento();
        
    }
}
