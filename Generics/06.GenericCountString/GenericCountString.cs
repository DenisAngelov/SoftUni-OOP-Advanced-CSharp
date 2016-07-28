using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.GenericCountString
{
    public class GenericCountString
    {
        public static void Main()
        {
            List<GenericBox<string>> stringGeneric = new List<GenericBox<string>>();
            int numOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfInputs; i++)
                stringGeneric.Add(new GenericBox<string>(Console.ReadLine()));

            string compareWith = Console.ReadLine();

            int biggerValues = 0;

            foreach (var item in stringGeneric)
                if (item.CompareTo(compareWith) > 0)
                    biggerValues++;

            Console.WriteLine(biggerValues);
        }

    }

    public class GenericBox<T> where T : IComparable<T>
    {
        T data;

        public GenericBox(T item)
        {
            this.data = item;
        }

        public int CompareTo(T other)
        {
            return this.data.CompareTo(other);
        }

        public override string ToString()
        {
            return $"{this.data.GetType().FullName}: {this.data}";
        }

    }
}
