using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesPessoa;

namespace Persistencia.cs
{
    public class PessoaPersistencia
    {
        public void Salvar(Pessoa p)
        {
            p.ValidaDocumento();
        }
    }
}
