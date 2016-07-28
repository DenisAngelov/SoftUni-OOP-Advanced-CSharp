using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Threeuple
{
    public class Threeuple
    {
        public static void Main()
        {
            string[] adressData = Console.ReadLine().Split();
            string[] beerData = Console.ReadLine().Split();
            string[] accountData = Console.ReadLine().Split();

            MyThreeuple<string, string, string> adress = new MyThreeuple<string, string, string>(adressData[0] + " " + adressData[1], adressData[2], adressData[3]);
            MyThreeuple<string, int, string> beers = new MyThreeuple<string, int, string>(beerData[0], int.Parse(beerData[1]), beerData[2] == "drunk" ? "True" : "False");
            MyThreeuple<string, double, string> numbers = new MyThreeuple<string, double, string>(accountData[0], double.Parse(accountData[1]), accountData[2]);

            Console.WriteLine(adress.ToString());
            Console.WriteLine(beers.ToString());
            Console.WriteLine(numbers.ToString());
        }
    }

    public class MyThreeuple<T1, T2, T3>
    {
        private T1 itemOne;
        private T2 itemTwo;
        private T3 itemThree;

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

        public T3 ItemThree
        {
            get
            {
                return this.itemThree;
            }

            private set
            {
                this.itemThree = value;
            }
        }

        public MyThreeuple(T1 itemOne, T2 itemTwo, T3 itemThree)
        {
            this.ItemOne = itemOne;
            this.ItemTwo = itemTwo;
            this.ItemThree = itemThree;
        }

        public override string ToString()
        {
            return $"{ItemOne} -> {ItemTwo} -> {ItemThree}";
        }

    }
}
