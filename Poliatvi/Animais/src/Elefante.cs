using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animais.src
{
    public class Elefante : Pets
    {
          public Elefante (){}

        public Elefante( string nome , string cor , string classe){}

        // sobre escreve ação
        public override void Brincadeiras(string brincar){
            Console.WriteLine($"{Nome} está : {brincar}");
        }

        public override void Comer(string alimentacao){
            Console.WriteLine($"{Nome} está {alimentacao} amendois ;)");
        }
    }
}