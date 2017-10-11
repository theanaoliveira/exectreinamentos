using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project;

namespace ProjectTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Valida_Pessoa()
        {
            var nome = "ana";
            var rg = "12.12.235-9";
            var cpf = "000.568.452-56";

            var pessoa = new Pessoa(nome, rg, cpf);

            var pessoaValida = pessoa.ValidaPessoa(nome, rg, cpf);

            Assert.AreEqual(true, pessoaValida);
        }

        [TestMethod]
        public void Nome_Pessoa_Nao_Pode_Ser_Vazio()
        {
            var pessoa = new Pessoa("ana", "", "");

            var pessoaValida = pessoa.ValidaNomePessoa();

            Assert.AreEqual(true, pessoaValida);
        }

    }
}
