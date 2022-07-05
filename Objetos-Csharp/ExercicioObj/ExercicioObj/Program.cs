using ExercicioObj.src;
using System;

namespace ExercicioObj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atividade classe Desenho da  Catarina");

            //instanciando
            Coelho sasao = new Coelho ("sasao" , "azul" , "acessorio");

            
            sasao.Pulando();
            sasao.Comer();

            Console.WriteLine($"Catarina fez uma {sasao.Name} e sua cor {sasao.Cor}");

        }
    }
}
