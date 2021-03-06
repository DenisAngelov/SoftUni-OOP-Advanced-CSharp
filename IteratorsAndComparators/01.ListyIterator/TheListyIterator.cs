﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ListyIterator
{
    public class TheListyIterator
    {
        public static void Main()
        {
            ListyIterator<string> listy;
            string command = Console.ReadLine();
            string[] createData = command.Split();

            if (createData.Length > 1)
            {
                string[] elements = createData.Skip(1).ToArray();
                listy = new ListyIterator<string>(elements);
            }
            else
                listy = new ListyIterator<string>();

            while ((command = Console.ReadLine()) != "END")
            {
                string[] commandData = command.Split();

                switch (commandData[0])
                {
                    case "Move": Console.WriteLine(listy.Move()); break;
                    case "Print": listy.Print(); break;
                    case "HasNext": Console.WriteLine(listy.HasNext()); break;
                }
            }
        }
    }

    public class ListyIterator<T>
    {
        private List<T> data;
        private int index = 0;

        public ListyIterator(T[] data)
        {
            this.data = new List<T>();
            Create(data);
        }

        public ListyIterator()
        {
            this.data = new List<T>();
        }

        private void Create(T[] data)
        {
            foreach (var item in data)
                this.data.Add(item);
        }

        public bool Move()
        {
            index++;

            if (this.index >= this.data.Count)
            {
                index--;
                return false;
            }
            else
                return true;
        }

        public bool HasNext()
        {
            if (this.index >= this.data.Count - 1)
                return false;
            else
                return true;
        }

        public void Print()
        {
            try
            {
                if (this.data.Count == 0)
                    throw new IndexOutOfRangeException();

                Console.WriteLine(this.data[index]);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Operation!");
            }
        }
    }
}
