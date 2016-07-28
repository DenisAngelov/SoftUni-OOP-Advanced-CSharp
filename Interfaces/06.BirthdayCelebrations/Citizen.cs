using System;

namespace _06.BirthdayCelebrations
{
    public class Citizen : IIdentificationable
    {
        private string name;
        private string id;
        private string birthday;
        private int age;

        public string Birthday
        {
            get
            {
                return this.birthday;
            }

            private set
            {
                this.birthday = value;
            }
        }

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

        public string Id
        {
            get
            {
                return this.id;
            }

            private set
            {
                this.id = value;
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

        public Citizen(string name, int age, string id, string birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthday = birthday;
        }

    }
}
