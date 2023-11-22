using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Interfaces.SOLID.OCP.SolucaoAbstracao
{
    public class Fisica : AFisicaJuridica, IFornecedor
    {
        public Fisica()
        {
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Credenciamento { get; set; }

        public void Salvar()
        {
            Console.WriteLine("Salvando fisica que é fornecedora");
        }
    }
}
