using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.SOLID.SRP.Solucao
{
    public class Validacao
    {
        public void Validar(Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.Nome))
            {
                throw new Exception("O nome é obrigatório");
            }

            if (string.IsNullOrEmpty(cliente.Telefone))
            {
                throw new Exception("O Telefone é obrigatório");
            }
        }
    }
}
