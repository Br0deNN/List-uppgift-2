using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();

        list.Add(5);
        list.Add(6);
        list.Add(7);
        Max(list);
    }

    static void Max(List<int>Lista)
    {
        Lista.Sort();
        Lista.RemoveRange(0, Lista.Count -1);
        foreach (int i in Lista)
        {
            Console.WriteLine(i);
        }

    }
}