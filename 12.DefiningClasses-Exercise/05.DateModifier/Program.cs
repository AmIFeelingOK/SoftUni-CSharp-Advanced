using System;
using System.Linq;

namespace _05.DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            DateModifier datemodifier = new DateModifier();

            datemodifier.StartDate = DateTime.Parse(Console.ReadLine());
            datemodifier.EndDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(Math.Abs(datemodifier.DayDifference()));
        }
    }
}
