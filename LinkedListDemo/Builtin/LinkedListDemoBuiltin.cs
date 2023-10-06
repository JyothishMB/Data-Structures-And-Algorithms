using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo.Builtin
{
    public class LinkedListDemoBuiltin
    {
        LinkedList<int> ints = new LinkedList<int>();

        public LinkedListDemoBuiltin()
        {
            
        }

        public void Add(int item)
        {
            if(ints.Count>0)
                ints.AddLast(item);
            else
                ints.AddFirst(item);
        }
    }
}
