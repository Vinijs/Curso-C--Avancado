using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Interfaces.SOLID.OCP.SolucaoAbstracao
{
    public abstract class AFisica
    {
        public string CNPJ { get; set; }
        public string InscricaoEstadual { get; set; }
    }
}
