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

            if (user == 0)
                Console.WriteLine("zero can't be converted");

            if (user > 100)
                Console.WriteLine("number cannot be greater than 100");
            else
            {
                string Output = NumberConverter.Conversion(user);
                Console.WriteLine(Output);
            }
            

            
            Console.ReadLine();
        }

        
    }
}
