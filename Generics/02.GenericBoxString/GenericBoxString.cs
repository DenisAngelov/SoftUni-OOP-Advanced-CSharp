using System;
using System.Collections.Generic;

namespace _02.GenericBoxString
{
    public class GenericBoxString
    {
        public static void Main()
        {
            List<GenericBox<string>> stringGeneric = new List<GenericBox<string>> ();
            int numOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfInputs; i++)
                stringGeneric.Add(new GenericBox<string>(Console.ReadLine()));

            foreach (var item in stringGeneric)
                Console.WriteLine(item.ToString());
        }
    }

    public class GenericBox<T>
    {
        T data;

        public GenericBox(T item)
        {
            this.data = item;
        }

        public override string ToString()
        {
            return $"{this.data.GetType().FullName}: {this.data}";
        }
    }
}
