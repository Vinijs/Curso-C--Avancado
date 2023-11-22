using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Tornese : Carro
    {
        public Tornese()
        {
            this.Marca = "Tornese";
        }
        public override void Salvar()
        {
            //base.Salvar();
            Console.WriteLine($"Um novo comportamento para está ação na marca {this.Marca}");
        }

        public new void Excluir()
        {
            base.Excluir();
            Console.WriteLine("Ação2 para excluir os dados");
        }

        public override List<Carro> BuscaPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        //public override List<Carro> BuscaPorNome(string nome)
        //{

        //}
    }
}
