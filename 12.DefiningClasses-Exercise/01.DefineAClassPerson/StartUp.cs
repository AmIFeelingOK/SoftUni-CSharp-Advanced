using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person("Peter", 22);
            Console.WriteLine($"Hello, my name is {person.Name} and I am {person.Age} years old.");
            
        }
    }
}
