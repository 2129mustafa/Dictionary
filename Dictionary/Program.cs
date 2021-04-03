using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new Dictionary.MyDictionary<int, string>();

            myDictionary.Add(456, "Mustafa");
            myDictionary.Add(789, "Burak");
            myDictionary.Add(123, "Halil");
            myDictionary.Add(852, "Ali");
            myDictionary.Add(258, "Erdem");

            Console.WriteLine(myDictionary.Count);

        }
    }
}
