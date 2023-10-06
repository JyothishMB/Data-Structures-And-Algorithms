using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo.Implementation
{
    public sealed class ColoredCustomLinkedList : CustomLinkedList
    {
        public override void AddLast(int e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            base.AddLast(e);
        }
        public override void AddFirst(int e)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            base.AddFirst(e);
        }
        public override void AddAfter(Node n, int e)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.AddAfter(n, e);
        }
        public override void RemoveFirst()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.RemoveFirst();
        }
        public override void RemoveLast()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            base.RemoveLast();
        }
        public override void Remove(int e)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            base.Remove(e);
        }

    }
}
