using System;
using System.Linq;
using System.Text;

namespace _08.CustomList
{
    public class CustomList
    {
        public static void Main()
        {
            CustList<string> elements = new CustList<string>();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] commandData = command.Split();

                switch (commandData[0])
                {
                    case "Add": elements.Add(commandData[1]); break;
                    case "Remove": elements.Remove(int.Parse(commandData[1])); break;
                    case "Contains": Console.WriteLine(elements.Contains(commandData[1])); break;
                    case "Swap": elements.Swap(int.Parse(commandData[1]), int.Parse(commandData[2])); break;
                    case "Greater": Console.WriteLine(elements.CountGreaterThan(commandData[1])); break;
                    case "Max": Console.WriteLine(elements.Max()); break;
                    case "Min": Console.WriteLine(elements.Min()); break;
                    case "Print": Console.Write(elements.ToString()); break;
                }
            }
        }
    }

    public class CustList<T> where T : IComparable
    {
        private const int InitialCapacity = 16;
        private T[] elements;
        private int count;

        public int Count
        {
            get { return this.count; }

            private set { this.count = value; }
        }

        public T this[int index]
        {
            get
            {
                if (index >= Count)
                    throw new IndexOutOfRangeException("Index was outside of bounds array.");

                return this.elements[index];
            }
        }

        public CustList()
        {
            this.elements = new T[InitialCapacity];
            this.Count = 0;
        }

        public void Add(T element)
        {
            if (this.Count + 1 == this.elements.Length)
                Resize();

            this.elements[this.Count] = element;
            Count++;
        }

        public T Remove(int index)
        {
            if (index >= Count)
                throw new IndexOutOfRangeException("Index was outside of bounds array.");

            T element = this.elements[index];
            DecreaseElementsCount(index);
            return element;
        }

        public bool Contains(T element)
        {
            if (elements.Any(el => el.Equals(element)))
                return true;
            else
                return false;
        }

        public void Swap(int indexSource, int indexDestination)
        {
            T temp = this.elements[indexSource];
            this.elements[indexSource] = this.elements[indexDestination];
            this.elements[indexDestination] = temp;
        }

        public int CountGreaterThan(T element)
        {
            int biggerValuesCount = 0;

            for (int ele = 0; ele < Count; ele++)
                if (this.elements[ele].CompareTo(element) > 0)
                    biggerValuesCount++;

            return biggerValuesCount;
        }

        public T Max()
        {
            if (this.Count == 0)
                throw new InvalidOperationException("Cannot perform operation on the given sequence.");

            T maxElement = this.elements[0];

            for (int ele = 1; ele < this.Count; ele++)
                if (maxElement.CompareTo(this.elements[ele]) < 0)
                    maxElement = this.elements[ele];

            return maxElement;
        }

        public T Min()
        {
            if (this.Count == 0)
                throw new InvalidOperationException("Cannot perform operation on the given sequence.");

            T minElement = this.elements[0];

            for (int ele = 1; ele < this.Count; ele++)
                if (minElement.CompareTo(this.elements[ele]) > 0)
                    minElement = this.elements[ele];

            return minElement;
        }

        private void Resize()
        {
            int currLength = this.elements.Length;
            T[] newElements = new T[currLength * 2];
            Array.Copy(this.elements, newElements, currLength);
            this.elements = newElements;
        }

        private void DecreaseElementsCount(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
                this.elements[i] = this.elements[i + 1];

            this.elements[Count - 1] = default(T);
            Count--;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int ele = 0; ele < Count; ele++)
                sb.AppendLine(this.elements[ele].ToString());

            return sb.ToString();
        }

    }
}
