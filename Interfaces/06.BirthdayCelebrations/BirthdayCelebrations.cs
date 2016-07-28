using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.BirthdayCelebrations
{
    public class BirthdayCelebrations
    {
        public static void Main(string[] args)
        {
            string input = string.Empty;
            List<IIdentificationable> birthdays = new List<IIdentificationable>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] entityDetails = input.Split();

                if (entityDetails[0] == "Citizen")
                    birthdays.Add(new Citizen(entityDetails[1], int.Parse(entityDetails[2]), entityDetails[3], entityDetails[4]));
                else if (entityDetails[0] == "Pet")
                    birthdays.Add(new Pet(entityDetails[1], entityDetails[2]));
            }

            string yearOfBthd = Console.ReadLine();
            var birthdayEntities = birthdays.Where(i => i.Birthday.EndsWith(yearOfBthd));

            foreach (var entity in birthdayEntities)
                Console.WriteLine(entity.Birthday);
        }
    }
}
