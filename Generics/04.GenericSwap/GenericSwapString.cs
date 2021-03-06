﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.GenericSwapString
{
    public class GenericSwapString
    {
        public static void Main()
        {
            List<GenericBox<string>> stringGeneric = new List<GenericBox<string>>();
            int numOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfInputs; i++)
                stringGeneric.Add(new GenericBox<string>(Console.ReadLine()));

            int[] swapPossitions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            stringGeneric = Swap(stringGeneric, swapPossitions[0], swapPossitions[1]);
            
            foreach (var item in stringGeneric)
                Console.WriteLine(item.ToString());
        }

        public static List<T> Swap<T>(List<T> list, int indexA, int indexB)
        {
            T temp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = temp;
            return list;
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
