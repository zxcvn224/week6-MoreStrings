using System;

namespace AnotherStringToReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab laused "Hello world" tagurpidi

            string helloW = "Hello World";

            for (int i = helloW.Length - 1; i >= 0; i--)
            {
                Console.Write(helloW[i]);
            }
            Console.WriteLine();
        }
    }
}
