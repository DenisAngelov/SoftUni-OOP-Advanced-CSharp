using System;

namespace _03.Ferrari
{
    public class ProblemFerrari
    {
        public static void Main()
        {
            string driverName = Console.ReadLine();
            ICar newCar = new Ferrari(driverName);
            Console.WriteLine(newCar.ToString());

            string ferrariName = typeof(Ferrari).Name;
            string iCarInterfaceName = typeof(ICar).Name;

            bool isCreated = typeof(ICar).IsInterface;
            if (!isCreated)
            {
                throw new Exception("No interface ICar was created");
            }
        }
    }
}
