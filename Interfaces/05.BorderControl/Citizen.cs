using System;

namespace _05.BorderControl
{
    public class Citizen : IEntity
    {
        private string id;
        private string name;
        private int age;

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

        public string endOfId
        {
            get
            {
                return this.id.Substring(id.Length - 3, 3);
            }
        }

        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

    }
}
