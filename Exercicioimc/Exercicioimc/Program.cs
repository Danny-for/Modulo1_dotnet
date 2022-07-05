using System;

namespace Exercicioimc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float altura, peso;
            float imc;

            Console.WriteLine("Seja bem vinde !!!");

            Console.WriteLine("Digite sua altura : ");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu peso : ");
            peso = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine("Você está abaixo do seu peso atual ");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Seu peso é normal ");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Você está um acima do peso ");
            }
            else if (imc >= 30)
            {
                Console.WriteLine("Você está com obesidade ");
            }

        }
    }
}
