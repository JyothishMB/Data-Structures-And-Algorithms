using StackDemo.Implementtion.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            StackArray stackArray = new StackArray(10);
            stackArray.push(1);
            stackArray.push(2);
            stackArray.push(3);
            stackArray.push(4);
            stackArray.push(5);
            Console.WriteLine(stackArray.ToString());

            Console.ForegroundColor = ConsoleColor.Red;
            stackArray.pop();
            stackArray.pop();
            Console.WriteLine(stackArray.ToString());

            Console.ForegroundColor = ConsoleColor.Blue;
            stackArray.peek();
            Console.WriteLine(stackArray.ToString());

            Console.ReadKey();

        }
    }
}
