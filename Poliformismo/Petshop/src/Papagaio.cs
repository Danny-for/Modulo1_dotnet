using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petshop.src
{
    public class Papagaio : Animal
    {
        // construtor vazio
          public Papagaio (){}


        public Furao( string nome , string cor , string tamamho , string classe){}

        // sobre escreve ação brinacadeira
        public override void Brincadeiras(string brincar){
            Console.WriteLine($"{Nome} está : {brincar}");
        }

        public override void Comer(string alimentacao){
            Console.WriteLine($"{Nome} está {alimentacao} frutinhass ;)");
        }

    }
}