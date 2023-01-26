using System;

namespace Iterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = "Peatear Hearte";

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
            Console.ReadLine();
        }
    }
}

