using KataFizzBuzzLib;
using System;

namespace ConsoleAppKataFizzBuzz
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var repeat = true;
            while (repeat)
            {

                Console.WriteLine("Entrez un chiffre de 1 à 100");
                int user = int.Parse(Console.ReadLine());


                if (user > 100)
                    Console.WriteLine("number cannot be greater than 100");
                else if (user != 0)
                {
                    string Output = NumberConverter.Conversion(user);
                    Console.WriteLine(Output);
                }
                else
                {
                    Console.WriteLine("zero can't be converted");
                }

            }

            Console.Read();
        }


    }
}
