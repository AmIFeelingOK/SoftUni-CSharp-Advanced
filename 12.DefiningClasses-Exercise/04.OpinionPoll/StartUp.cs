using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] member = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person currentPerson = new Person(member[0], int.Parse(member[1]));

                if (currentPerson.Age > 30)
                {
                    family.AddMember(currentPerson);
                }
            }

            family.FamilyMembers.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList().ForEach(Console.WriteLine);
        }
    }
}
