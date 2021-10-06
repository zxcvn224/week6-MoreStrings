using System;

namespace HOcounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab mitu 'h', 'o' ja 'l' tähte on lauses "Hello, world!"

            string helloW = "Hello World".ToLower();

            int counterH = 0;
            int counterO = 0;
            int counterL = 0;

            for(int i = 0; i < helloW.Length; i++)
            {
                if (helloW[i] == 'h')
                {
                    counterH++;
                }
                else if(helloW[i] == 'o')
                {
                    counterO++;
                }
                else if (helloW[i] == 'l')
                {
                    counterL++;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine($"Lauses on {helloW} on {counterH} 'h' tähte ja {counterL} 'l' tähte");
        }
    }
}
