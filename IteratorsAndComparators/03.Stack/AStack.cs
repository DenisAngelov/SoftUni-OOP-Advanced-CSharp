using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03.Stack
{
    public class AStack
    {
        public static void Main()
        {
            Stacky<string> stacky = new Stacky<string>();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] commandData = command.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                if (commandData[0].Equals("Push"))
                {
                    foreach (var element in commandData.Skip(1))
                        stacky.Push(element);
                }
                else
                    stacky.Pop();
            }

            foreach (var element in stacky)
                Console.WriteLine(element);

            foreach (var element in stacky)
                Console.WriteLine(element);
        }
    }

    public class Stacky<T> : IEnumerable<T>
    {
        private int sizeOfData = 16;
        private T[] data;
        private int index;

        public Stacky()
        {
            this.data = new T[sizeOfData];
            index = -1;
        }

        public void Push(T element)
        {
            if (index + 1 >= this.data.Length)
                Resize();

            index++;
            this.data[index] = element;
        }

        public void Pop()
        {
            if (this.data.Length == 0 || index < 0)
            {
                Console.WriteLine("No elements");
                return;
            }

            this.data[index] = default(T);
            index--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = index; i >= 0; i--)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.data.GetEnumerator();
        }

        private void Resize()
        {
            T[] newData = new T[this.data.Length * 2];
            Array.Copy(this.data, newData, newData.Length);
            this.data = newData;
        }

    }

}
