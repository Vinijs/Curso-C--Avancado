﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Interfaces.SOLID.OCP.SolucaoAbstracao
{
    public interface IJuridica
    {
        string CNPJ { get; set; }
        string InscricaoEstadual { get; set; }

    }
}
