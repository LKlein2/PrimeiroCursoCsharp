using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesPessoa
{
    public sealed class DocumentoInvalidoException : Exception
    {

        public DocumentoInvalidoException() : base("Documento inválido!") { }
        public DocumentoInvalidoException(String msg) : base(msg) { }

        //public override string Message
        //{
        //    get { return "Documento inválido!"; }
        //}
    }
}
