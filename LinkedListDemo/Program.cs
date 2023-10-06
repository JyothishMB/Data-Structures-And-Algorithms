using LinkedListDemo.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ColoredCustomLinkedList customlist= new ColoredCustomLinkedList();
            customlist.AddLast(1);
            Console.WriteLine(customlist.ToString());
            customlist.AddLast(2);
            Console.WriteLine(customlist.ToString());
            customlist.AddLast(3);
            Console.WriteLine(customlist.ToString());

            customlist.AddFirst(30);
            Console.WriteLine(customlist.ToString());
            customlist.AddAfter(customlist.FindLast(2), 10);
            Console.WriteLine(customlist.ToString());
            customlist.RemoveFirst();
            Console.WriteLine(customlist.ToString());
            customlist.RemoveLast();
            Console.WriteLine(customlist.ToString());
            customlist.Remove(2);
            Console.WriteLine(customlist.ToString());


            ColoredCustomLinkedList sortedlist = new ColoredCustomLinkedList();

            sortedlist.SortedInsert(10);
            Console.WriteLine(sortedlist.ToString());
            sortedlist.SortedInsert(8);
            Console.WriteLine(sortedlist.ToString());
            sortedlist.SortedInsert(7);
            Console.WriteLine(sortedlist.ToString());
            sortedlist.SortedInsert(70);
            Console.WriteLine(sortedlist.ToString());
            sortedlist.SortedInsert(1);
            Console.WriteLine(sortedlist.ToString());

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
