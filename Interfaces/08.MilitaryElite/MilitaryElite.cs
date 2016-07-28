using System;
using System.Collections.Generic;
using _08.MilitaryElite.Models;
using _08.MilitaryElite.Soldiers;
using System.Linq;

namespace _08.MilitaryElite
{
    public class MilitaryElite
    {
        public static void Main(string[] args)
        {
            List<ISoldier> soldiers = new List<ISoldier>();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandData = command.Split();

                string id = commandData[1];
                string firstName = commandData[2];
                string lastName = commandData[3];
                float salary;
                string corps;

                switch (commandData[0])
                {
                    case "Private":
                        salary = float.Parse(commandData[4]);
                        soldiers.Add(new Private(id, firstName, lastName, salary));
                        break;
                    case "LeutenantGeneral":
                        salary = float.Parse(commandData[4]);

                        int numOfPrivates = commandData.Length - 5;
                        List<ISoldier> privates = new List<ISoldier>();
                        string[] asd = commandData.Skip(5).Take(numOfPrivates).ToArray();

                        for (int i = 0; i < numOfPrivates; i++)
                            privates.Add(soldiers.First(p => p.Id == asd[i]));

                        soldiers.Add(new LeutenantGeneral(id, firstName, lastName, salary, privates));

                        break;
                    case "Engineer":
                        salary = float.Parse(commandData[4]);
                        corps = commandData[5];
                        try
                        {
                            string[] parts = commandData.Skip(6).Take(commandData.Length - 6).ToArray();
                            soldiers.Add(new Engineer(id, firstName, lastName, salary, corps, parts));
                        }
                        catch (Exception)
                        {
                        }
                        break;
                    case "Commando":
                        salary = float.Parse(commandData[4]);
                        corps = commandData[5];
                        try
                        {
                            string[] missions = commandData.Skip(6).Take(commandData.Length - 6).ToArray();
                            soldiers.Add(new Commando(id, firstName, lastName, salary, corps, missions));
                        }
                        catch (Exception)
                        {
                        }
                        break;
                    case "Spy":
                        string codeNumber = commandData[4];
                        soldiers.Add(new Spy(id, firstName, lastName, codeNumber));
                        break;
                }
            }

            foreach (ISoldier soldier in soldiers)
                Console.WriteLine(soldier.ToString());
        }
    }
}
