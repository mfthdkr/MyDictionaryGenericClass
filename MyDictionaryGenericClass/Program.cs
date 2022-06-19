using System;
using System.Collections.Generic;

namespace MyDictionaryGenericClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            Console.WriteLine(dictionary.Count);
            dictionary.Add(1, "Fatih");
            dictionary.Add(2, "Ahmet");
            Console.WriteLine(dictionary.Count);

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            Console.WriteLine(myDictionary.Count);
            myDictionary.Add(1, "Fatih");
            myDictionary.Add(2, "Ali");
            myDictionary.Add(3, "Mustafa");
            myDictionary.Add(4, "İsmail");
            Console.WriteLine(myDictionary.Count);
        }
    }
}
