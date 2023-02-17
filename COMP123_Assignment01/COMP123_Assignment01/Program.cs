using System;
using COMP123_Assignment01.Models;
namespace COMP123_Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational rational = new Rational(); // Zero Arugements


            Rational rational1 = new Rational(1); // 1 Arguement


            Rational rational2 = new Rational(1, 5); // 2 Arguements


            Rational rational3 = new Rational(numerator: 4, denominator: 9); // Named Arguement


            // 2 Pairs to be printed to Console:

            Console.WriteLine($"{rational2} + {rational3} = ...");
            rational2.IncreaseBy(rational3);
            Console.WriteLine($"> {rational2}\n");

            Console.WriteLine($"{rational3} - {rational1} = ...");
            rational3.DecreaseBy(rational1);
            Console.WriteLine($"> {rational3}\n");
        }
    }
}
