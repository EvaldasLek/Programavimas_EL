using System;


namespace Uzduotis04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /* Susikurkite skaičiaus kintamąjį, 
             * kurį išveskite penkis kartus toje pačioje eilutėje
             * be tarpų tarp šių skaičių 
             * (skaičius - 25, išvedimas - 2525252525).
             */

            int number = 25;
            Console.Write(number);
            Console.Write(number);
            Console.Write(number);
            Console.Write(number);
            Console.WriteLine(number);   
        }
    }
}
