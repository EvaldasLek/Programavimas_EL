using System;


namespace Uzduotis06
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /* Parašyti Mano vardas tarp eilučių
             */
            string startLine = "------------------------";
            string emptyLine = "|                       |";
            string name = "E V A L D A S";
            Console.WriteLine(startLine);
            Console.WriteLine(emptyLine);
            Console.WriteLine(emptyLine);
            Console.WriteLine("|       Mano vardas     |");
            Console.WriteLine("|      " + name + "    |");
            Console.WriteLine(emptyLine);
            Console.WriteLine(emptyLine);
            Console.WriteLine(startLine);
            Console.WriteLine();
        }
    }
}
