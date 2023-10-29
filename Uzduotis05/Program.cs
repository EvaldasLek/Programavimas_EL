using System;


namespace Uzduotis05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Susikurkite skaičiaus kintamąjį, 
             * kurį išveskite penkis kartus toje pačioje eilutėje 
             * su tarpais tarp šių skaičių 
             * (skaičius - 25, rezultatas - 25 25 25 25 25 - su tarpais).
             */
            int number = 25;
            Console.WriteLine("{0} {0} {0} {0} {0}", number);

            {
                Console.WriteLine($"{number} {number} {number} {number} {number}");
                Console.WriteLine();
            }
            
        }
    }
}
