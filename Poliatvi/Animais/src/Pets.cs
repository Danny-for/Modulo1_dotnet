using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animais.src
{
    public class Pets
    {
         //atributos que o animal terá
        public string Nome {get; set;}

        public string Cor {get; set;}

        public string  Classe {get; set;}


    //Construtor com Parametros
        public Animal( string nome , string cor , string classe){
            Nome = nome;
            Cor = cor;
            Classe = classe;
        }


     // metodo ação do parametro

        public virtual void Brincadeiras(string brincar){
            Console.WriteLine($"{Nome} está : {brincar}");
        }

        public virtual void Comer(string alimentacao){
            Console.WriteLine($"{Nome} está {alimentacao} humhaaa ;) ");
        }
    }
}