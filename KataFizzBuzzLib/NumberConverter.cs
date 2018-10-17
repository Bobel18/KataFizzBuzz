using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace KataFizzBuzzLib
{
   public static class NumberConverter
    {
        

        public static string Output { get; private set; }

        public static string Conversion(int input)
        {
            if (input == 0)
                throw new ArgumentException("zero can't be converted");

            if (input > 100)
                throw new NumberTooHightException();

            if ((input % 3) == 0 && (input % 5) == 0) 
            {
                Output = "Fizz" + "Buzz";
            }
            
            else if (input % 3 == 0)
            {
                 Output = "Fizz";
            }

            else if (input % 5 == 0)
            {
                Output = "Buzz";
            }

            else
            {
                Output = input.ToString();
            }
            return Output;
        }

   }    
        public class NumberTooHightException : Exception
        {


            public NumberTooHightException() : base("number cannot be greater than 100")
            {
            }

        }


    
    }
