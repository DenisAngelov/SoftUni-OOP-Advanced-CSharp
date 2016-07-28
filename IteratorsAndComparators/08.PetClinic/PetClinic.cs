using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.PetClinic
{
    public class PetClinic
    {
        public static void Main()
        {
            int numOfCommands = int.Parse(Console.ReadLine());

            Dictionary<string, Pet> pets = new Dictionary<string, Pet>();
            Dictionary<string, Clinic> clinics = new Dictionary<string, Clinic>();

            for (int i = 0; i < numOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split();
                string clinicName = string.Empty;

                switch (command[0])
                {
                    case "Create":

                        if (command[1].Equals("Pet"))
                        {
                            string name = command[2];
                            int age = int.Parse(command[3]);
                            string kind = command[4];
                            pets.Add(name, new Pet(name, age, kind));
                        }
                        else
                        {
                            string name = command[2];
                            int rooms = int.Parse(command[3]);
                            try
                            {
                                clinics.Add(name, new Clinic(name, rooms));

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }

                        break;
                    case "Add":
                        string petName = command[1];
                        clinicName = command[2];
                        Console.WriteLine(clinics[clinicName].Add(pets[petName]).ToString());
                        break;
                    case "Release":
                        clinicName = command[1];
                        Console.WriteLine(clinics[clinicName].Release().ToString());
                        break;
                    case "HasEmptyRooms":
                        clinicName = command[1];
                        Console.WriteLine(clinics[clinicName].HasEmptyRooms().ToString());
                        break;
                    case "Print":
                        clinicName = command[1];
                        if (command.Length == 2)
                        {
                            clinics[clinicName].Print();
                        }
                        else
                        {
                            int roomNum = int.Parse(command[2]) - 1;
                            clinics[clinicName].PrintRoom(roomNum);
                        }
                        break;
                }
            }
        }
    }

    public class Clinic
    {
        private string name;
        private int rooms;
        private Pet[] pets;
        private int centerRoom;

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

        public int Rooms
        {
            get
            {
                return this.rooms;
            }

            private set
            {
                if (value % 2 == 0 || value < 0 || value > 101)
                    throw new ArgumentException("Invalid Operation!");

                this.rooms = value;
            }
        }

        public Clinic(string name, int rooms)
        {
            this.Name = name;
            this.Rooms = rooms;
            pets = new Pet[Rooms];
            centerRoom = Rooms / 2;
        }

        public bool Add(Pet newPet)
        {
            int roomIndex = centerRoom;
            int left = roomIndex - 1;
            int right = roomIndex + 1;

            if (pets[roomIndex] == null)
            {
                pets[roomIndex] = newPet;
                return true;
            }

            while (roomIndex != Rooms - 1)
            {
                if (pets[left] == null)
                {
                    pets[left] = newPet;
                    return true;
                }

                if (pets[right] == null)
                {
                    pets[right] = newPet;
                    return true;
                }

                roomIndex = right;
            }

            return false;
        }

        public bool Release()
        {
            if (pets.Length == 0)
                return false;

            for (int i = centerRoom; i < rooms; i++)
            {
                if (pets[i] != null)
                {
                    pets[i] = default(Pet);
                    return true;
                }
            }

            for (int i = 0; i < centerRoom; i++)
            {
                if (pets[i] != null)
                {
                    pets[i] = default(Pet);
                    return true;
                }
            }

            return false;
        }

        public bool HasEmptyRooms()
        {
            return pets.Any(x => x == null);
        }

        public void Print()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var pet in pets)
            {
                if (pet == null)
                {
                    Console.WriteLine("Room empty");
                    continue;
                }
                Console.WriteLine($"{pet.Name} {pet.Age} {pet.Kind}");
            }
        }

        public void PrintRoom(int numOfRoom)
        {
            if (pets[numOfRoom] == null)
            {
                Console.WriteLine("Room empty");
                return;
            }

            Console.WriteLine(pets[numOfRoom].ToString());
        }
    }

    public class Pet
    {
        private string name;
        private int age;
        private string kind;

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (value.Length < 1 || value.Length > 50)
                    throw new ArgumentException("Pet name must be shorter or bigger!");

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
                if (value < 1 || value > 100)
                    throw new ArgumentException("Invalid age!");
                
                this.age = value;
            }
        }

        public string Kind
        {
            get
            {
                return this.kind;
            }

            private set
            {
                if (value.Length < 1 || value.Length > 50)
                    throw new ArgumentException("Kind name must be shorter or bigger!");

                this.kind = value;
            }
        }

        public Pet(string name, int age, string kind)
        {
            this.Name = name;
            this.Age = age;
            this.Kind = kind;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age} {this.Kind}";
        }

    }
}
