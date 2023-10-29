using System;
using System.Diagnostics.Eventing.Reader;

namespace Uzduotis07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /* Liepkite vartotojui įvesti savo vardą ir amžių. 
             * Į ekraną išveskite: “Jūsų vardas {vardas}, 
             * o amžius {amžius}.”
             */
            Console.Write("Įveskite savo vardą: ");
            string vardas = Console.ReadLine();

            Console.Write("Įveskite savo amžių: ");
            string amziusString = Console.ReadLine();

            if (int.TryParse(amziusString, out int amzius));

            {
                Console.WriteLine($"Jūsų vardas {vardas}, o amžius {amzius}.");
            }

            {

                /*Liepkite vartotojui įvesti bet kokį simbolį. 
                 * Atspausdinkite 3x3 kvadratą iš to simbolio.
                 */
                Console.Write("Įveskite bet kokį simbolį: ");
                char simbolis = Console.ReadKey().KeyChar;

                Console.WriteLine();

                for (int i = 0; i < 3; i++) 
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(simbolis);
                    }

                    Console.WriteLine();
                
                }

            }
        }
    }
}
