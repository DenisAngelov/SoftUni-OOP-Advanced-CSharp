using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BorderControl
{
    public class BorderControl
    {
        public static void Main()
        {
            string passenger = string.Empty;
            List<IEntity> entities = new List<IEntity>();

            while ((passenger = Console.ReadLine()) != "End")
            {
                string[] details = passenger.Split();

                if (details.Length == 2)
                    entities.Add(new Robot(details[0], details[1]));
                else
                    entities.Add(new Citizen(details[0], int.Parse(details[1]), details[2]));
            }

            string detainedId = Console.ReadLine();

            var detainedPassengers = entities.Where(i => i.Id.EndsWith(detainedId));

            foreach (var detainedPassenger in detainedPassengers)
                Console.WriteLine(detainedPassenger.Id);
        }
    }
}
