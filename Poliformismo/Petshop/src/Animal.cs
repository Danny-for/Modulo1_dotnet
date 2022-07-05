using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petshop.src
{
    public class Animal
    {
        //atributos que o animal terá
        public string Nome {get; set;}

        public string Cor {get; set;}

        public int Tamanho {get; set;}

        public string  Classe {get; set;}


    //Construtor com Parametros
        public Animal( string nome , string cor , string tamamho , string classe){
            Nome = nome;
            Cor = Cor;
            Tamanho = Tamanho;
            Classe = Classe;
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