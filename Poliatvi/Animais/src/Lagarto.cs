using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animais.src
{
    public class Lagarto : Pets
    {
         public Lagarto (){}

        public Lagarto( string nome , string cor , string classe){}

        // sobre escreve ação
        public override void Brincadeiras(string brincar){
            Console.WriteLine($"{Nome} está : {brincar}");
        }

    }
}