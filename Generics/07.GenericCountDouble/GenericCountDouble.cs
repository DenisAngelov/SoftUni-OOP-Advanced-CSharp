using System;
using System.Collections.Generic;

namespace _07.GenericCountDouble
{
    public class GenericCountDouble
    {
        public static void Main()
        {
            List<GenericBox<double>> genericDouble = new List<GenericBox<double>>();
            int numOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfInputs; i++)
                genericDouble.Add(new GenericBox<double>(double.Parse(Console.ReadLine())));

            double compareWith = double.Parse(Console.ReadLine());

            int biggerValues = 0;

            foreach (var item in genericDouble)
                if (item.CompareTo(compareWith) > 0)
                    biggerValues++;

            Console.WriteLine(biggerValues);
        }
    }

    public class GenericBox<T> where T : IComparable<T>
    {
        private T data;

        public GenericBox(T data)
        {
            this.data = data;
        }

        public int CompareTo(T item)
        {
            return this.data.CompareTo(item);
        }

        public override string ToString()
        {
            return $"{this.data.GetType().FullName}: {this.data}";
        }
    }
}
