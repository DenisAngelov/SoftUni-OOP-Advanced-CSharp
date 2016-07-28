using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _04.Froggy
{
    public class Froggy
    {
        public static void Main()
        {
            int[] data = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Frogy frogy = new Frogy(data);

            string result = string.Join(", ", frogy);
            Console.WriteLine(result);
        }
    }

    public class Frogy : IEnumerable<int>
    {
        private List<int> data;

        public Frogy(int[] elements)
        {
            data = new List<int>(elements);
        }

        public Frogy()
        {
            data = new List<int>();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < data.Count; i+=2)
                yield return data[i];

            int lastIndex = 0;

            if (this.data.Count % 2 == 0)
                lastIndex = this.data.Count - 1;
            else
                lastIndex = this.data.Count - 2;

            for (int i = lastIndex; i >= 0; i-=2)
                yield return data[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
