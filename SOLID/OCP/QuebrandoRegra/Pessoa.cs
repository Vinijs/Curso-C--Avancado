using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Interfaces.SOLID.OCP.QuebrandoRegra
{
    public class Pessoa
    {
        public Pessoa()
        {
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public TipoPessoa Tipo { get; set; }

        public void Salvar()
        {
            if(this.Tipo == TipoPessoa.Fisica)
            {
                Console.WriteLine("Salvando física");
            }
            else if(this.Tipo == TipoPessoa.Juridica)
            {
                Console.WriteLine("Salvando juridica");
            }
            else if (this.Tipo == TipoPessoa.Fornecedor)
            {
                Console.WriteLine("Salvando fornecedor");
            }
        }
    }
}
