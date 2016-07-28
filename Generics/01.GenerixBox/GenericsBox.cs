using System;

namespace _01.GenerixBox
{
    public class GenericsBox
    {
        public static void Main()
        {
            GenericBox<string> test = new GenericBox<string>();
            Console.WriteLine(test.ToString());
        }
    }
}
