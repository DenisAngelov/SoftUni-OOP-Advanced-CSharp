using System;
using System.Collections.Generic;

namespace _07.EqualityLogic
{
    public class EqualityLogic
    {
        public static void Main()
        {
            SortedSet<Person> sortedPeople = new SortedSet<Person>();
            HashSet<Person> hashedPeople = new HashSet<Person>();

            int numberOfInputs = int.Parse(Console.ReadLine());
            int counter = 0;


            while (counter < numberOfInputs)
            {
                string[] personData = Console.ReadLine().Split();

                Person currPerson = new Person(personData[0], int.Parse(personData[1]));
                sortedPeople.Add(currPerson);
                hashedPeople.Add(currPerson);
                counter++;
            }

            Console.WriteLine(sortedPeople.Count);
            Console.WriteLine(hashedPeople.Count);

        }
    }

    public class Person : IComparable<Person>
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

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Person person = obj as Person;
            if (person == null)
                return false;

            return (this.Name == person.Name) && (this.Age == person.Age);
        }

        public override int GetHashCode()
        {
            return new { this.Name, this.Age }.GetHashCode();
        }

        public int CompareTo(Person other)
        {
            if (this.Name.CompareTo(other.Name) < 0)
                return -1;

            if (this.Name.CompareTo(other.Name) == 1)
                return 1;

            return this.Age.CompareTo(other.Age);
        }
    }

}
