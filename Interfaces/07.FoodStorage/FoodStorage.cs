using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.FoodStorage
{
    public class FoodStorage
    {
        public static void Main(string[] args)
        {
            Dictionary<string, IBuyer> buyers = new Dictionary<string, IBuyer>();
            int numberOfEntities = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEntities; i++)
            {
                string[] entity = Console.ReadLine().Split();

                if (entity.Length == 3)
                    buyers.Add(entity[0], new Rebel(entity[0], int.Parse(entity[1]), entity[2]));
                else
                    buyers.Add(entity[0], new Citizen(entity[0], int.Parse(entity[1]), entity[2], entity[3]));
            }

            string consumer = string.Empty;

            while ((consumer = Console.ReadLine()) != "End")
            {
                if (!buyers.ContainsKey(consumer))
                    continue;
                buyers[consumer].BuyFood();
            }

            int foodTotal = buyers.Sum(c => c.Value.Food);
            Console.WriteLine(foodTotal);
        }
    }
}
