using System;


namespace Uzduotis01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello world");
            
            Console.WriteLine("Apie mane:");
            var vardas = "Evaldas";
            Console.WriteLine("Vardas " + vardas);
            string pavarde = "Lekavicius";
            Console.WriteLine("Pavarde " + pavarde);

            // Mano amžius,ūgis, svoris, universitetas ir pavadinimas

            int amzius = 48;
            Console.WriteLine("Amzius " + amzius);
            int ugis = 177;
            Console.WriteLine("Ugis " + ugis);
            float svoris = 86;
            Console.WriteLine("Svoris " + svoris);
            string aukstasismokslas = "Kauno Technologijos Universitetas";
            Console.WriteLine("Aukstasis mokslas " + aukstasismokslas);
            int akademinesgrupeskodas = 2;
            Console.WriteLine("Akademines grupes kodas " + akademinesgrupeskodas);
            string kursas = "Neakivaizdinis";
            Console.WriteLine("Kursas " + kursas);
            string studijosprogramospavadinimas = "Testuotojai";
            Console.WriteLine("Studijos programos pavadinimas " + studijosprogramospavadinimas);
            int atsiskaitytukredituskaicius = 100;
            Console.WriteLine("Atsiskaitytu kreditu skaicius " + atsiskaitytukredituskaicius);
        }
    }
}
