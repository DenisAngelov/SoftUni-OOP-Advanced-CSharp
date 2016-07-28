using System;
using System.Collections.Generic;

namespace _10.ExplicitInterface
{
    public class ExplicitInterface
    {
        public static void Main()
        {
            List<IResident> residents = new List<IResident>();
            List<IPerson> people = new List<IPerson>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputData = input.Split();

                string name = inputData[0];
                string country = inputData[1];
                int age = int.Parse(inputData[2]);

                Citizen currCitizen = new Citizen(name, country, age);
                residents.Add(currCitizen);
                people.Add(currCitizen);
            }

            for (int i = 0; i < residents.Count; i++)
            {
                Console.WriteLine(people[i].GetName());
                Console.WriteLine(residents[i].GetName());
            }

        }
    }

    public class Citizen : IResident, IPerson
    {
        private string name;
        private string country;
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

        public string Country
        {
            get
            {
                return this.country;
            }

            private set
            {
                this.country = value;
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

        public Citizen(string name, string country, int age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;
        }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {this.Name}";
        }

        string IPerson.GetName()
        {
            return this.Name;
        }
    }

    public interface IResident
    {
        string Name { get; }
        string Country { get; }

        string GetName();
    }

    public interface IPerson
    {
        string Name { get; }
        int Age { get; }

        string GetName();
    }
}
