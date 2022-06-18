using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person("Uiuimuiui", 792);
            Console.WriteLine($"{person.Name} {person.Age}");
        }
    }
}
