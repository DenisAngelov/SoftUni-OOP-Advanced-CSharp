using System;
using System.Collections.Generic;

namespace _05.ComparingObjects
{
    public class ComparingObjects
    {
        public static void Main()
        {
            string input = string.Empty;
            List<Person> people = new List<Person>();

            while ((input = Console.ReadLine()) != "END")
            {
                string[] personData = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = personData[0];
                int age = int.Parse(personData[1]);
                string town = personData[2];

                people.Add(new Person(name, age, town));
            }

            int numOfPerson = int.Parse(Console.ReadLine()) - 1;
            Person baseComparePerson = people[numOfPerson];

            int equalPeople = 0;
            int differentPeople = 0;

            foreach (var person in people)
            {
                int currMatch = baseComparePerson.CompareTo(person);

                if (currMatch == 0)
                    equalPeople++;
                else
                    differentPeople++;
            }

            if (equalPeople != 1)
                Console.WriteLine($"{equalPeople} {differentPeople} {people.Count}");
            else
                Console.WriteLine("No matches");


        }
    }

    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

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

        public string Town
        {
            get
            {
                return this.town;
            }

            private set
            {
                this.town = value;
            }
        }

        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public int CompareTo(Person other)
        {
            if (this.Name.CompareTo(other.Name) < 0)
                return this.name.CompareTo(other.name);

            if (this.Age.CompareTo(other.Age) < 0)
                return this.Age.CompareTo(other.Age);
            
            return this.Town.CompareTo(other.Town);
        }
    }
}
