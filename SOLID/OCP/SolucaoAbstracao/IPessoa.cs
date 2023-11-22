using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Interfaces.SOLID.OCP.SolucaoAbstracao
{
    public interface IPessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        void Salvar();
    }
}
