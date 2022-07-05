using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá mallu seja bem - vinda a calculadora virtual : ");

            Console.WriteLine("Calculadora");
            Console.WriteLine("Quer ligar a calculadora (sim ou não)");
            string open = Console.ReadLine();

            string close = "não" ;



            if (open  == "sim")
            { 

            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o operador: ");
            string operador = Console.ReadLine();

            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());


                switch (operador)
                {
                    case "+":
                        Console.WriteLine("Resultado: " + somar(num1, num2));
                        break;
                    case "-":
                        Console.WriteLine("Resultado: " + subtrair(num1, num2));
                        break;
                    case "*":
                        Console.WriteLine("Resultado: " + multiplicar(num1, num2));
                        break;
                    case "/":
                        Console.WriteLine("Resultado: " + dividir(num1, num2));
                        break;
                }

            }
            else if (close != "não")
            {
                Console.WriteLine("Não pode usar a calculadora");
            }
        }


    }

        public static string somar(int num1, int num2)
        {
            return (num1 + num2).ToString();
        }
        public static string subtrair(int num1, int num2)
        {
            return (num1 - num2).ToString();
        }
        public static string multiplicar(int num1, int num2)
        {
            return (num1 * num2).ToString();
        }
        public static string dividir(int num1, int num2)
        {
            if (valorDividendoMenorOuIgualAZero(num2))
            {
                return "Não é possivel dividir por zero ou menor que zero";
            }
            return (num1 / num2).ToString();

            bool valorDividendoMenorOuIgualAZero(int num2)
            {
                if (num2 <= 0)
                {
                    return true;
                }
                return false;
            }
        }






    }


}

