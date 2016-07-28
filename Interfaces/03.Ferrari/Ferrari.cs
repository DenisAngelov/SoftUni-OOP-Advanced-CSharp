using System;

namespace _03.Ferrari
{
    public class Ferrari : ICar
    {
        private string driver;
        private string model;

        public string Driver
        {
            get
            {
                return this.driver;
            }

            private set
            {
                this.driver = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                this.model = value;
            }
        }

        public Ferrari(string driver)
        {
            this.Driver = driver;
            this.Model = "488-Spider";
        }

        public string Start()
        {
            return "Zadu6avam sA!";
        }

        public string Stop()
        {
            return "Brakes!";
        }

        public override string ToString()
        {
            return $"{Model}/{Stop()}/{Start()}/{Driver}";
        }
    }
}
