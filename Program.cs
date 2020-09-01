using System;
using System.Collections.Generic;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DLList list=new DLList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.DisplayAll();
            // list.Remove(4);
            list.Reverse();
            list.DisplayAll();
            Console.WriteLine(list.Head.Value);
            Console.WriteLine(list.Tail.Value);
        }
    }
}
