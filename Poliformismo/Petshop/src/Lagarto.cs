using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petshop.src
{
    public class Lagarto : Animal
    {
        public Lagarto (){}

        public Lagarto( string nome , string cor , string tamamho , string classe){}

        // sobre escreve ação
        public override void Brincadeiras(string brincar){
            Console.WriteLine($"{Nome} está : {brincar}");
        }

    }
}