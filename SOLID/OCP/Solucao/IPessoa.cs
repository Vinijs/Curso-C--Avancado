using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Interfaces.SOLID.OCP.Solucao
{
    public interface IPessoa
    {
        int Id { get; set; }
        string Nome { get; set; }

        void Salvar();
    }
}
