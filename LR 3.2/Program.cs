
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        
        var dictionary = new Dictionary<string, int>(5);
        dictionary.Add("cat", 1);
        dictionary.Add("dog", 0);
        dictionary.Add("mouse", 5);
        dictionary.Add("eel", 3);
        dictionary.Add("programmer", 2);
        foreach (var s in dictionary.Keys)
        {
            Console.Write(s + " ");
        }
       
        var list = dictionary.Keys.ToList();
        list.Sort();
        
        
        foreach (var key in list)
        {
            Console.WriteLine("\n {0}: {1}", key, dictionary[key]);
        }
    }
}

