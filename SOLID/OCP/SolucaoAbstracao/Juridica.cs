﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Interfaces.SOLID.OCP.SolucaoAbstracao
{
    public class Juridica: IPessoa, IJuridica
    {
        public Juridica()
        {
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string InscricaoEstadual { get; set; }

        public void Salvar()
        {
            Console.WriteLine("Salvando juridica");
        }
    }
}