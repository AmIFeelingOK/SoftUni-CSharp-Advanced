using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> FamilyMembers { get; set; }
        public Family()
        {
            FamilyMembers = new List<Person>();
        }

        public void AddMember(Person person)
        {
            FamilyMembers.Add(person);
        }

        public Person GetOldestMember()
        {
            int maxAge = FamilyMembers.Max(x => x.Age);
            return FamilyMembers.First(x => x.Age == maxAge);
        }
    }
}
