using KataFizzBuzzLib;
using System;

namespace ConsoleAppKataFizzBuzz
{
    public static class Program
    {
        public static void Main(string[] args)
        {
           
            //    var repeat = true;
            //while (repeat)
            //{
                for (int i = 1; i <= 100; i++)
                {
                string Output = NumberConverter.Conversion(i);
                Console.WriteLine(Output);
                
                }



                //int user = int.Parse(Console.ReadLine());


                //if (user > 100)
                //    Console.WriteLine("number cannot be greater than 100");
                //else if (user != 0)
                //{
                   
                //}
                //else
                //{
                   // Console.WriteLine("zero can't be converted");
                //}

           //}

            Console.Read();
        }


    }
}
