using System;

namespace MoreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm tervitab kasutajat kasutades tema initsiaale
            //initsiaalid lõpevad punktiga
            //--> Harry potter <-- H. P.


            Console.WriteLine("Sisestage enda eesnimi");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Sisesta enda perekonnanimi");
            string perekonnanimi = Console.ReadLine();

            Console.WriteLine($"Tere, {eesnimi[0]}. {perekonnanimi[0]}.");

        }
    }
}
