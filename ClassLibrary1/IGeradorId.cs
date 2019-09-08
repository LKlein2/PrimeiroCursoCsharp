using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesPessoa
{
    public interface IGeradorId
    {
        void GerarId();
    }

    public interface IValida
    {
        bool valida();
    }
}
