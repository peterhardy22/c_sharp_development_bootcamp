using System;

namespace Condtionals
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            // bool isGoldCustomer = true;

            // float price = (isGoldCustomer) ? 19.95f : 29.95f;
            // Console.WriteLine(price);

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("It could be Autumn or Summer and this will still print.");
                    break;

                default:
                    Console.WriteLine("I do not understand.");
                    break;
            }
            Console.ReadLine();
        }
    }

}
