using System;

namespace _07.FoodStorage
{
    public class Citizen : IBuyer
    {
        private string id;
        private string name;
        private int age;
        private string birthday;
        private int food;

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

        public int Food
        {
            get
            {
                return this.food;
            }
        }

        public Citizen(string name, int age, string id, string birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthday = birthday;
            this.food = 0;
        }

        public void BuyFood()
        {
            this.food += 10;
        }
    }
}
