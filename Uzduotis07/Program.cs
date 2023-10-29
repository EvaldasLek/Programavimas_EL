using System;
using System.ComponentModel.Design;
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

                    {
                        /*Liepkite vartotojui įvesti bet kokį skaičių. 
                         * Išveskite į ekraną šio skaičiaus kvadratą.
                         */

                        Console.Write("Įveskite bet kokį skaičių: ");
                        if (int.TryParse(Console.ReadLine(), out int skaicius));
                        {
                            int kvadratas = skaicius * skaicius;
                            Console.WriteLine($"Skaičiaus {skaicius} kvadratas yra {kvadratas}");
                        }

                        {
                            Console.WriteLine("Prašome įvesti skaičių.");
                        }

                        {
                            /* Liepkite vartotojui įvesti tris skaičius. 
                             * Išveskite visų šių skaičių sumą, 
                             * nurodant atliekamus veiksmus ir šių skaičių reikšmes ekrane.
                             * Pvz.:5 + 3 + 8 = 16
                             */
                            Console.Write("Įveskite pirmajį skaičių: ");
                            if (int.TryParse(Console.ReadLine(), out int pirmasSkaicius)) ;
                            {
                                Console.Write("Įveskite antrajį skaičių: ");
                                if (int.TryParse(Console.ReadLine(), out int antrasSkaicius)) ;
                            }
                            {
                                Console.Write("Įveskite trečiajį skaičių: ");
                                if (int.TryParse(Console.ReadLine(), out int treciasSkaicius)) ;
                            }

                            {
                                int suma = pirmasSkaicius + antrasSkaicius + treciasSkaicius;
                                Console.WriteLine($"{pirmasSkaicius} + {antrasSkaicius} + {treciasSkaicius});
                            }
                            else
                            {
                                Console.WriteLine("Trečias įvestas tekstas nėra skaičius. Prašome įvesti skaičių");
                            }
                            else
                            {
                                Console.WriteLine("Antras įvestas tekstas nėra skaičius. Prašome įvesti skaičių");
                            }
                            else
                            {
                                Console.WriteLine("Trečias įvestas tekstas nėra skaičius. Prašome įvesti skaičių");
                                Console.WriteLine();

                            }

                        }

                    }
                
                }

            }
        }
    }
}
