using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassesPessoa;

namespace ClassesTestes
{
    [TestClass]
    public class TestesDeUnidade1
    {
        [TestMethod]
        public void ValidaAtribuicaoId()
        {
            DateTime d = DateTime.Now;
            PessoaFisica p = new PessoaFisica(50, d);
            Assert.AreEqual(p.Id, 50);
            Assert.AreEqual(p.DataCadastro, d);
        }

        [TestMethod]
        [ExpectedException(typeof(DocumentoInvalidoException))]
        public void TestValidaDocuemntoInvalido()
        {
            PessoaFisica p = new PessoaFisica(1, DateTime.Now);
            p.Cpf = "0009988";

            p.ValidaDocumento();
        }

        [TestMethod]
        public void TestValidaDocuemntoValido()
        {
            PessoaFisica p = new PessoaFisica(1, DateTime.Now);
            p.Cpf = "12345678900";

            p.ValidaDocumento();
        }
    }
}
