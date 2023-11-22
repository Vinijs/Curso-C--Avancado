using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Interfaces.SOLID.SRP.Solucao
{
    public class Cliente
    {
        public Cliente()
        {
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }

        public bool Valido()
        {
            return string.IsNullOrEmpty(this.Nome) ? false : true;
        }
    }
}
