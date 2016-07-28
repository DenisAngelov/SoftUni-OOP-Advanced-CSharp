using System;
using System.Collections.Generic;
using System.Text;

namespace _09.CollectionHierarchy
{
    public class CollectionHierarchy
    {
        public static void Main()
        {
            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            string[] elements = Console.ReadLine().Split();
            int removeOperations = int.Parse(Console.ReadLine());

            for (int i = 0; i < elements.Length; i++)
            {
                addCollection.Add(elements[i]);
                addRemoveCollection.Add(elements[i]);
                myList.Add(elements[i]);
            }

            for (int i = 0; i < removeOperations; i++)
            {
                addRemoveCollection.Remove();
                myList.Remove();
            }

            addCollection.PrintDataInformation(elements.Length);
            addRemoveCollection.PrintDataInformation(elements.Length);
            myList.PrintDataInformation(elements.Length);

            Console.WriteLine(addRemoveCollection.RemovedData);
            Console.WriteLine(myList.RemovedData);
        }
    }

    public class AddCollection : ICollections
    {
        private List<string> data;

        public IReadOnlyList<string> Data => this.data;

        public AddCollection()
        {
            this.data = new List<string>();
        }

        public void Add(string element)
        {
            this.data.Add(element);
        }

        public void PrintDataInformation(int numOfElements)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < numOfElements; i++)
                sb.Append(i + " ");

            Console.WriteLine(sb.ToString().Trim());
        }
    }

    public class AddRemoveCollection : ICollections, IModifiableCollection
    {
        private List<string> data;
        private StringBuilder removedData;

        public IReadOnlyList<string> Data => this.data;
        public string RemovedData => removedData.ToString().Trim();

        public AddRemoveCollection()
        {
            this.data = new List<string>();
        }

        public void Add(string element)
        {
            this.data.Insert(0, element);
            removedData = new StringBuilder();
        }

        public void PrintDataInformation(int numOfElements)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < numOfElements; i++)
                sb.Append(0 + " ");

            Console.WriteLine(sb.ToString().Trim());
        }

        public void Remove()
        {
            int lastElementPos = this.data.Count - 1;
            this.removedData.Append(this.data[lastElementPos] + " ");
            this.data.RemoveAt(lastElementPos);
        }
    }

    public class MyList : ICollections, IModifiableCollection
    {
        private List<string> data;
        private StringBuilder removedData;

        public IReadOnlyList<string> Data => this.data;

        public string RemovedData => removedData.ToString().Trim();

        public MyList()
        {
            this.data = new List<string>();
            removedData = new StringBuilder();
        }

        public void Add(string element)
        {
            this.data.Insert(0, element);
        }

        public void PrintDataInformation(int numOfElements)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < numOfElements; i++)
                sb.Append(0 + " ");

            Console.WriteLine(sb.ToString().Trim());
        }

        public void Remove()
        {
            removedData.Append(this.data[0] + " ");
            this.data.RemoveAt(0);
        }
    }

    public interface ICollections
    {
        void Add(string element);
        void PrintDataInformation(int numOfElements);
    }

    public interface IModifiableCollection
    {
        string RemovedData { get; }

        void Remove();
    }
}
