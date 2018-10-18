using KataFizzBuzzLib;
using System;

namespace ConsoleAppKataFizzBuzz
{
    public static class Program
    {
        public static void Main(string[] args)
        {
           

            Console.WriteLine("Entrez un chiffre de 1 à 100");
            int user = int.Parse(Console.ReadLine());

           string Output = NumberConverter.Conversion(user);

            Console.WriteLine(Output);
            Console.ReadLine();
        }

        
    }
}
