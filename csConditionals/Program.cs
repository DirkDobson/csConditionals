﻿using System;

namespace csConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
