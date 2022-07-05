using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petshop.src
{
    // furao herdou de petshop
    public class Furao : Animal
    {
        public Furao (){}

        public Furao( string nome , string cor , string tamamho , string classe){}

        // sobre escreve ação
        public override void Brincadeiras(string brincar){
            Console.WriteLine($"{Nome} está : {brincar}");
        }

        public override void Comer(string alimentacao){
            Console.WriteLine($"{Nome} está {alimentacao} frutinhass ;)");
        }


    }
}