using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    public class ProdutoAlmoxarifado
    {
        private Produto produto;
        private Almoxarifado almoxarifado;
        private int quantidade;

        public Produto Produto
        {
            get { return this.produto; }
            set { this.produto = value; }
        }
        public Almoxarifado Almoxarifado
        {
            get { return this.almoxarifado; }
            set { this.almoxarifado = value; }
        }

        public int Quantidade
        {
            get { return this.quantidade; }
            set { this.quantidade = value; }
        }

        public ProdutoAlmoxarifado() { }
        public ProdutoAlmoxarifado(Produto produto, Almoxarifado almoxarifado, int quantidade)
        {
            this.Produto = produto;
            this.Almoxarifado = almoxarifado;
            this.Quantidade = quantidade;
        }
    }
}
