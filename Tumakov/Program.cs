using System;

namespace Tumakov
{
    class Program
    {
        static void Main(string[] args)
        {
            ex412();
        }
         enum Months
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12,
        }
        static void ex412()
        {
            Console.WriteLine("Написать программу, которая читает с экрана число от 1 до 365 (номер дня в году), переводит" +
                "это число в месяц и день месяца. Например, число 40 соответствует 9 февраля (високосный год не учитывается)");
            Console.WriteLine("Введите число от 1 до 365");
            DateTime begin = (DateTime.MinValue);
            double numInput = Convert.ToSingle(Console.ReadLine());
            if (numInput < 1 | numInput > 365)
            {
                Console.WriteLine("You've entered a wrong number! Try again.");
            }
            else
            {
                DateTime newdate = begin.AddDays(numInput - 1);
                string dateString = newdate.ToString();
                Console.WriteLine("Enter a year");
                int year = Convert.ToInt32(Console.ReadLine());
                string newString = dateString.Remove(5).Replace(".", "");
                int intdate = Convert.ToInt32(newString);
                int month = intdate % 100;
                int day = intdate / 100;
                Console.WriteLine(day + " " + Enum.GetName(typeof(Months), month) + " " + year);
            }
        }
    }
}
