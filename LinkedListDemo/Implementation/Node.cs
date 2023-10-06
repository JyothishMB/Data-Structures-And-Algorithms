using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo.Implementation
{
    public class Node
    {
        private int element;
        public int Element 
        { 
            get 
            { 
                return element; 
            } 
            set 
            {
                element = value; 
            } 
        }

        private Node next;
        public Node Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }

        public Node(int e, Node n)
        {
            Element = e;
            Next = n;
        }
    }
}
