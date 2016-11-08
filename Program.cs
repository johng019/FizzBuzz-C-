using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //for numbers 1 thru 100 increment the number by 1
            for (int i = 1; i <= 100; i++)
            {
                //for a number divisable by 3 AND 5
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + " Fizz Buzz");
                }
                //for a number divisable by 5 only
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " Buzz");
                }
                //for a number divisable by 3 only
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " Fizz");
                }
                //for any number not included above
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
