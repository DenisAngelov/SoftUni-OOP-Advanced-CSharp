using System;

namespace _07.FoodStorage
{
    public class Rebel : IBuyer
    {
        private string name;
        private int age;
        private string group;
        private int food;

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

        public string Group
        {
            get
            {
                return this.group;
            }

            private set
            {
                this.group = value;
            }
        }

        public int Food
        {
            get
            {
                return this.food;
            }
        }

        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
            this.food = 0;
        }

        public void BuyFood()
        {
            this.food += 5;
        }
    }
}
