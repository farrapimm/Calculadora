using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();

        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Escolha a operação a ser executada.");
            Console.WriteLine("1- Soma");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão");
            Console.WriteLine("5- Sair");
            short res = short.Parse(Console.ReadLine());

            /*if (res == 1)
            { soma(); }
            else if (res == 2)
            { subtracao(); }
            else if (res == 3)
            { multiplicacao(); }
            else if (res == 4)
            { divisao(); }
            else if (res < 1)
            {
                Console.WriteLine("Escolha um numero valido!");
                Menu();
            }
            else if (res > 4)
            {
                Console.WriteLine("Escolha um numero valido!");
                Menu();
            }
            else { }*/
            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }


        static void Soma()
        {
            Console.Clear(); //Limpa o console antes de executar.

            Console.WriteLine("Escreva um valor.");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escreva outro valor.");
            float n2 = float.Parse(Console.ReadLine());

            float resultado = n1 + n2;
            Console.WriteLine("O resultado da soma de " + (n1) + " e " + (n2) + " é: " + (resultado));
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear(); //Limpa o console antes de executar.

            Console.WriteLine("Escreva um valor.");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escreva outro valor.");
            float n2 = float.Parse(Console.ReadLine());

            float resultado = n1 - n2;
            Console.WriteLine("O resultado da subtração de " + (n1) + " e " + (n2) + " é: " + (resultado));
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear(); //Limpa o console antes de executar.

            Console.WriteLine("Escreva um valor.");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escreva outro valor.");
            float n2 = float.Parse(Console.ReadLine());

            float resultado = n1 * n2;
            Console.WriteLine("O resultado da multiplicação de " + (n1) + " e " + (n2) + " é: " + (resultado));
            Menu();
        }

        static void Divisao()
        {
            Console.Clear(); //Limpa o console antes de executar.

            Console.WriteLine("Escreva um valor.");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escreva outro valor.");
            float n2 = float.Parse(Console.ReadLine());

            float resultado = n1 / n2;
            Console.WriteLine("O resultado da divisão de " + (n1) + " por " + (n2) + " é: " + (resultado));
            Menu();
        }

    }
}
