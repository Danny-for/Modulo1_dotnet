using System;
using System.Collections.Generic;
using Animais.src;

namespace Animais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey !!! venha conhecer nossos animais ;) ");

            List<Pets> pet = new List<Pets>(
                new Pets[]{
                    new Furao("Furao Carlos" , "Preto" ,"Macho"),
                    new Papagaio ("Papagaio frederico" , "verde" , "Macho" ),
                    new  Furao("Furão Elisa" , "Marrom" , "Fêmea") ,
                    new Papagaio ("Pepe" , "Cinza" , "Fêmea"),
                    new Elefante ("Cacau" , "Azul" , "Fêmea"),
                    new Furao("lu", "ruiva" ,"fêmea")

                }
            );

            foreach(Pets pets in pet )
            {
                if(pets.Classe == "Fêmea"){
                    Console.WriteLine($"{pets.Nome} e {pets.Classe}");

                }
                else if (pet.Classe == "Macho")
                {
                    Console.WriteLine($"{pets.Nome} e um {pets.Classe}");
                }
            }
            
        }
    }  

}
