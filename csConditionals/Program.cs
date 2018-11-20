using System;


namespace csConditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            var seaons = Seasons.Autmun;

            switch (Seasons)
            {
                case Season.Autumn:
                    Console.WriteLine("It's Autumn");
                    break;
                case Seasons.Summer:
                    Console.WriteLine("It's Summer");
                    break;
                default:
                    Console.WriteLine("I don't know that season");
                    break;
        }

            int hour = 10;

            if (hour > 0&& hour < 12)
            {
                Console.WriteLine("It's Morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("it's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }

            bool isGoldCustomer = true;
            float price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);

        }
    }
}
