using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.LinkedListTraversal
{
    public class LinkedListTraversal
    {
        public static void Main()
        {
            LinkList<int> linkList = new LinkList<int>();
            int numOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfInputs; i++)
            {
                string[] command = Console.ReadLine().Split();
                string method = command[0];
                int number = int.Parse(command[1]);

                if (method.Equals("Add"))
                    linkList.Add(number);
                else
                    linkList.Remove(number);

            }

            Console.WriteLine(linkList.Data.Count);

            Console.WriteLine(linkList.ToString());

        }
    }

    public class LinkList<T> : IEnumerable<T>
    {
        private List<T> data;
        public IReadOnlyList<T> Data => this.data;

        public LinkList()
        {
            this.data = new List<T>();
        }

        public void Add(T element)
        {
            this.data.Add(element);
        }

        public void Remove(T element)
        {
            if (this.data.Any(x => x.Equals(element)))
                this.data.Remove(this.data.First(x => x.Equals(element)));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in this.data)
                sb.Append(item + " ");

            return sb.ToString().Trim();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < data.Count; i++)
                yield return data[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
