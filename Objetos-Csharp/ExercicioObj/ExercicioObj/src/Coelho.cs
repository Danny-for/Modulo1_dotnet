using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioObj.src
{
    class Coelho
    {

        //atributos
        public string Name { get; set; }//pega e altera
        public string Cor { get; set; }


        // construtor do coelho 
        public Coelho(string _name , string _cor , string _acessorio )
        {
            Name = _name;
            Cor = _cor;
            acessorio = _acessorio;
        }

        //metodos //ações 

        public void Comer()
        {
            Console.WriteLine("Coelho comendo cenoura ;)");
        }

        public void Pulando()// printa sem retorno
        {
            Console.WriteLine("Coelho está pulando no campo");
        }

        public string Brincando()// não printa mais dá o retorno 
        {
            return ("Coelho brincando");
        }


        
    }


}
