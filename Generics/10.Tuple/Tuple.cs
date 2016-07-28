using System;

namespace _10.Tuple
{
    public class Tuple
    {
        public static void Main()
        {
            string[] adressData = Console.ReadLine().Split();
            string[] beerData = Console.ReadLine().Split();
            string[] numbersData = Console.ReadLine().Split();

            MyTuple<string, string> adress = new MyTuple<string, string>(adressData[0] + " " + adressData[1], adressData[2]);
            MyTuple<string, int> beers = new MyTuple<string, int>(beerData[0], int.Parse(beerData[1]));
            MyTuple<int, double> numbers = new MyTuple<int, double>(int.Parse(numbersData[0]), double.Parse(numbersData[1]));

            Console.WriteLine(adress.ToString());
            Console.WriteLine(beers.ToString());
            Console.WriteLine(numbers.ToString());

        }
    }

    public class MyTuple<T1, T2>
    {
        private T1 itemOne;
        private T2 itemTwo;

        public T1 ItemOne
        {
            get
            {
                return this.itemOne;
            }

            private set
            {
                this.itemOne = value;
            }
        }

        public T2 ItemTwo
        {
            get
            {
                return this.itemTwo;
            }

            private set
            {
                this.itemTwo = value;
            }
        }

        public MyTuple(T1 itemOne, T2 itemTwo)
        {
            this.ItemOne = itemOne;
            this.ItemTwo = itemTwo;
        }

        public override string ToString()
        {
            return $"{ItemOne} -> {ItemTwo}";
        }

    }

}
