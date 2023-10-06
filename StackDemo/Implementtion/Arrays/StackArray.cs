using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo.Implementtion.Arrays
{
    public class StackArray
    {
        int[] data;
        int top;

        public StackArray()
        {
            
        }
        public StackArray(int size)
        {
            data = new int[10];
            top = 0;
        }

        public int push(int item)
        {
            data[top++] = item;
            return top;
        }
        public int pop()
        {
            int item = data[top - 1];
            top -= 1;
            return item;
        }

        public int peek()
        {
            return data[top - 1];
        }

        public override string ToString()
        {
            string displaystring = string.Empty;
            int i = 0;
            while(i<top)
            {
                displaystring = displaystring + data[i].ToString() + "|";
                i++;
            }
            return displaystring;
        }
    }
}
