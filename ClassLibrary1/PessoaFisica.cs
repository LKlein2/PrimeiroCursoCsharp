using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesPessoa
{
    //Se colocar public seald class ... não deixa mais ser herdado.
    public class PessoaFisica : Pessoa
    {
        private string cpf;
        private string nome;

        //Equivalente ao Super() do java == Base(arg1, arg2)
        public PessoaFisica(int id, DateTime dataCadastro) : base(id, dataCadastro)
        {

        }

        public string Cpf
        {
            get { return this.cpf; }
            set { this.cpf = value; }
        }

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public PessoaFisica EncontrarPorcpf(string cpf)
        {
            return null;
        }

        public override void ValidaDocumento()
        {
            if (this.Cpf.Length != 11)
            {
                throw new DocumentoInvalidoException("CPF Inválido!");
            }
        }

        //public override void GerarId()
        //{
        //    base.GerarId();
        //    this.Id = this.Id + 5;
        //}

        public override string ToString()
        {
            return base.ToString() + " PESSOA FISICA: " + this.Id + "-" + this.nome;
        }
    }
}
