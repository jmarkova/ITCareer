﻿using System;
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6**. 1000 дни на Земята
            string date = Console.ReadLine();
            DateTime time = DateTime.ParseExact(date,"dd-MM-yyyy",
                System.Globalization.CultureInfo.InvariantCulture);
            time = time.AddDays(999);
            Console.WriteLine(time.ToString("dd-MM-yyyy"));
        }
    }
}
