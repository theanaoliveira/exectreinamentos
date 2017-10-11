using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey(true);
        }
    }
    
    public class Pessoa
    {
        public string nome { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }

        public Pessoa(string nome, string rg, string cpf)
        {
            this.nome = nome;
            this.rg = rg;
            this.cpf = cpf;
        }


        public bool ValidaPessoa(string nome, string rg, string cpf)
        {
            bool pessoaValida = false;

            if (this.nome == nome && this.rg == rg && this.cpf == cpf)
            {
                pessoaValida = true;
            }

            return pessoaValida;
        }

        public bool ValidaNomePessoa()
            => !String.IsNullOrEmpty(this.nome);
    }
}
