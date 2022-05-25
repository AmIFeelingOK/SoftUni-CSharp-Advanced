using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, List<decimal>>();

            int numberOfStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] information = Console.ReadLine().Split();

                string name = information[0];
                decimal grade = decimal.Parse(information[1]);

                if (!dictionary.ContainsKey(name))
                    dictionary.Add(name, new List<decimal>());

                dictionary[name].Add(grade);
            }

            foreach (var name in dictionary.Keys)
            {
                List<decimal> grades = dictionary[name];
                string gradeStr = string.Join(" ", grades.Select(x => x.ToString("f2")));

                decimal average = grades.Average();

                Console.WriteLine($"{name} -> {gradeStr} (avg: {average:f2})");
            }
        }
    }
}
