using System;
using System.Globalization;

namespace Calculadora
{
    class Calculadora
    {
        enum Menu { Somar = 1, Subtrair, Multiplicar, Dividir, Sair }


        static void Soma()
        {

            Console.WriteLine("Você escolheu soma. Digite o primeiro número:");
            double num1 = double.Parse((Console.ReadLine()));
            Console.WriteLine("Digite o segundo número:");
            double num2 = double.Parse((Console.ReadLine()));
            double SomaResult = num1 + num2;
            Console.WriteLine($"O resultado dessa soma é: {SomaResult.ToString("F1", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Digite qualquer tecla para voltar para o menu.");
            Console.ReadKey();
        }
     

        static void Subtrair()
        {
            Console.WriteLine("Você escolheu subtração. Digite o primeiro número:");
            double num1 = double.Parse((Console.ReadLine()));
            Console.WriteLine("Digite o segundo número:");
            double num2 = double.Parse((Console.ReadLine()));
            double SubResult = num1 - num2;
            Console.WriteLine($"O resultado dessa subtração é: {SubResult.ToString("F1", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Digite qualquer tecla para voltar para o menu.");
            Console.ReadKey();

        }

        static void Multiplicar()
        {

            Console.WriteLine("Você escolheu multiplicação. Digite o primeiro número:");
            double num1 = double.Parse((Console.ReadLine()));
            Console.WriteLine("Digite o segundo número:");
            double num2 = double.Parse((Console.ReadLine()));
            double MultResult = num1 * num2;
            Console.WriteLine(MultResult.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine($"Digite qualquer tecla para voltar para o menu.");
            Console.ReadKey();

        }

        static void Dividir()
        {

            Console.WriteLine("Você escolheu divisão. Digite o primeiro número:");
            double num1 = double.Parse((Console.ReadLine()));
            Console.WriteLine("Digite o segundo número:");

            double num2 = double.Parse((Console.ReadLine()));
            double DivResult = num1 / num2;
            Console.WriteLine(DivResult.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine($"Digite qualquer tecla para voltar para o menu.");
            Console.ReadKey();

        }




        static void Main(string[] args)
        {

            bool exit = false;

            while (exit == false)
            {

                Console.WriteLine("Bem vindo a calculadora. \n Digite a opção desejada:");
                Console.WriteLine("1 - Somar \n2 - Subtrair \n3 - Multiplicar \n4 - Dividir \n5 - Encerrar calculadora");
                int option = int.Parse(Console.ReadLine());

                Menu menu = (Menu)option;

                switch (menu)
                {

                    case Menu.Somar:
                        Soma();
                        break;
                    case Menu.Subtrair:
                        Subtrair();
                        break;
                    case Menu.Multiplicar:
                        Multiplicar();
                        break;
                    case Menu.Dividir:
                        Dividir();
                        break;
                    case Menu.Sair:
                        Console.WriteLine("Deseja encerrar a calculadora? Aperte qualquer tecla para confirmar.");
                        Console.ReadKey();
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opção incorreta. Digite novamente uma opção a partir do menu.");
                        break;
                }
                Console.Clear();
            }
            

        }
    }
}
