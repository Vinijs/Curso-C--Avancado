//using Interfaces.SOLID.SRP.QuebrandoRegra;
using Interfaces.SOLID.LSP.Solucao;
using Interfaces.SOLID.OCP.QuebrandoRegra;
using Interfaces.SOLID.OCP.SolucaoAbstracao;
using Interfaces.SOLID.SRP.Solucao;
using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruta fruta = new Toranja();
            //Fruta fruta = new Laranja();




            Console.Write($"A cor da toranja é: {fruta.Cor()}");

           

            Console.ReadKey();

            //var cliente = new Cliente();
            //cliente.Id = 1;
            //cliente.Nome = "Danilo";
            //cliente.Telefone = "123432123";
            //cliente.Salvar();

            /*
            var clienteSrp = new Cliente();
            clienteSrp.Nome = "Danilo";
            clienteSrp.Telefone = "123432123";
            try
            {
                new Validacao().Validar(clienteSrp);
                new Repositorio().Salvar(ref clienteSrp);
                new Sms().Enviar(clienteSrp);
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Erro ao validar {erro.Message}");
                throw;
            }

            /*
            Fisica pessoaFisica = new Fisica();
            IPessoa pessoaJuridica = new Juridica();

            //pessoaFisica.

            pessoaJuridica.Id = 1;
            pessoaJuridica.Nome = "ssss";
            pessoaJuridica.Salvar();

            pessoaFisica.Id = 1;
            pessoaFisica.Nome = "ssss";
            pessoaFisica.Salvar();




            // TODO Abstração
            //var carro = new Carro();
            //Console.WriteLine("========== TUP ===============");
            //var veiculo = new Tup();
            //veiculo.Ano = 2020;
            //veiculo.Nome = "004DV";
            //veiculo.Salvar();

            /*
            Console.WriteLine("========== TORNESE ===============");
            var veiculo2 = new Tornese();
            veiculo2.Ano = 2020;
            veiculo2.Nome = "005DV";
            veiculo2.Salvar();
           

            var joao = new Joao();
            //joao.
             */



        }
    }
}
