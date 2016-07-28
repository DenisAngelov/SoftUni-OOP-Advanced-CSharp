using System;
using System.Linq;

namespace _04.Telephony
{
    public class SmartPhone : IDialing, IBrowsing
    {
        private string model;

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

        public SmartPhone(string model)
        {
            this.Model = model;
        }

        public void BrowseInternet(string url)
        {

            if (url.Any(c => char.IsDigit(c)))
                Console.WriteLine("Invalid URL!");
            else
                Console.WriteLine($"Browsing: {url}!");
        }

        public void CallNumber(string number)
        {
            if (number.Any(c => !char.IsDigit(c)))
                Console.WriteLine("Invalid number!");
            else
                Console.WriteLine($"Calling... {number}");
        }
    }
}