using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesPessoa
{
    public class PessoaJuridica : Pessoa
    {
        private string cnpj;
        private string razaoSocial;

        //Equivalente ao Super() do java == Base(arg1, arg2)
        public PessoaJuridica(int id, DateTime dataCadastro) : base(id, dataCadastro)
        {

        }

        public string Cnpj
        {
            get { return this.cnpj; }
            set { this.cnpj = value; }
        }

        public string RazaoSocial
        {
            get { return this.razaoSocial; }
            set { this.razaoSocial = value; }
        }

        public PessoaJuridica EncontrarPorCNPJ(string cnpj)
        {
            return null;
        }

        public override void ValidaDocumento()
        {
            if (this.Cnpj.Length != 14)
            {
                throw new DocumentoInvalidoException("CNPJ Inválido!");
            }
        }

        //public override void GerarId()
        //{
        //    base.GerarId();
        //    this.Id = this.Id + 2;
        //}

        public override string ToString()
        {
            return base.ToString() + " PESSOA JURIDICA: " + this.Id + "-" + this.RazaoSocial;
        }
    }
}
