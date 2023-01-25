using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Peter";
            var lastName = "Harty";

            var fullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(fullName);

            var names = new string[3] { "Cassie", "Mickie", "Josie" };
            var formattedNames = string.Join(", ", names);
            Console.WriteLine(formattedNames);

            var text = @"Hi Clyde
Look into the following paths
c:\Accounts\Betty
c:\Finances\Timmy";
            Console.WriteLine(text);
            Console.ReadLine(); 
        }
    }
}
