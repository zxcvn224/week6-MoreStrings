using System;

namespace ACharCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string lastname = Console.ReadLine();
            string fullname = firstName + lastname.ToLower();
            int counter = 0;

            for (int i = 0; i < fullname.Length; i++)
            {
                if (fullname[i] == 'a')
                {
                    counter++;
                }
                if(fullname[i] == 'A')
                {
                    counter++;
                }

            }

            Console.WriteLine($"Sinu nimes on {counter} a-tähte");


        }
    }
}
