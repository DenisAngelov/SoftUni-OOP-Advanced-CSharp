using System;

namespace _04.Telephony
{
    public class Telephony
    {
        public static void Main()
        {
            SmartPhone myPhone = new SmartPhone("myModel");
            string[] numbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();

            foreach (string number in numbers)
                myPhone.CallNumber(number);

            foreach (string url in urls)
                myPhone.BrowseInternet(url);
        }
    }
}
