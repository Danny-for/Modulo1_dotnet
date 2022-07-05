using System;

namespace tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int valor, num;
            Console.WriteLine("Coloque o número para ter a tabuada : ");

            valor = int.Parse(Console.ReadLine());

            for (num = 1; num <= 10; num++)
            {
                Console.WriteLine($"{num} X {valor} = {num * valor}");
            }


        }
    }
}
