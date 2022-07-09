using System;

namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Hi Master! what type of conversion will be useful to you today?  ");
            Console.WriteLine("1- Hours");
            Console.WriteLine("2- Minutes  ");
            Console.WriteLine("3- Milliseconds ");
            Console.WriteLine("4- Seconds  ");
            Console.WriteLine("Press 0 to exit ");
            Console.WriteLine("****************************************************************");
            short Options =short.Parse(Console.ReadLine());

            switch(Options){
                case 1 : Hours();break;
                case 2 : Minutes();break;
                case 3 : Milliseconds() ;break;
                case 4 : Seconds();break;
                case 0 : System.Environment.Exit(0);break;

            }

            static void Hours()
        {
            Console.WriteLine("Insira a quantidade de dias para a conversão");
            int horas = int.Parse(Console.ReadLine());
            Console.WriteLine("O resultado da conversão é: ");
            Console.WriteLine(horas * 24);

        }
        }
        static void Minutes()
        {
            Console.WriteLine("Insira a quantidade de dias para a conversão");
            int minutos = int.Parse(Console.ReadLine());

            Console.WriteLine("O resultado da conversão é: ");
            Console.WriteLine(minutos * 1440);
        }

        static void Milliseconds()
        {
            Console.WriteLine("Insira a quantidade de dias para a conversão");
            int milisegundos = int.Parse(Console.ReadLine());
            Console.WriteLine("O resultado da conversão é: ");
            Console.WriteLine(milisegundos * 86400000);

        }

        static void Seconds()
        {
            Console.WriteLine("Insira a quantidade de dias para a conversão");
            int segundos = int.Parse(Console.ReadLine());
             Console.WriteLine("O resultado da conversão é: ");
            Console.WriteLine(segundos * 86400);

        }
    }
}