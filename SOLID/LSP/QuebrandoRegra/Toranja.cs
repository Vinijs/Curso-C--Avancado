using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.SOLID.LSP.QuebrandoRegra
{
    public class Toranja
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual string Cor()
        {
            return "Vermelha";
        }
    }
}
