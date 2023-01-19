using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);

                Console.WriteLine(b);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("The number could no be converted to a byte.");
                Console.ReadLine();
            }

        }
    }
}
