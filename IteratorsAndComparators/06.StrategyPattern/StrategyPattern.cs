using System;
using System.Collections.Generic;

namespace _06.StrategyPattern
{
    public class StrategyPattern
    {
        public static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            SortedSet<Person> byAge = new SortedSet<Person>(new AgeComp());
            SortedSet<Person> byName = new SortedSet<Person>(new NameComp());

            for (int input = 0; input < numberOfInputs; input++)
            {
                string[] personData = Console.ReadLine().Split();
                string name = personData[0];
                int age = int.Parse(personData[1]);
                Person currPerson = new Person(name, age);
                byAge.Add(currPerson);
                byName.Add(currPerson);
            }

            foreach (var person in byName)
                Console.WriteLine(person.ToString());

            foreach (var person in byAge)
                Console.WriteLine(person.ToString());
        }
    }

    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                this.age = value;
            }
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }


    class NameComp : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int result = x.Name.Length.CompareTo(y.Name.Length);

            if (result == 0)
                result = x.Name[0].ToString().ToLower().CompareTo(y.Name[0].ToString().ToLower());

            return result;
        }
    }

    class AgeComp : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}
