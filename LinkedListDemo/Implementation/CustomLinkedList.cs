using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo.Implementation
{
    public class CustomLinkedList
    {
        private int size;
        private Node head;
        private Node tail;
        public int Size
        {
            get
            {
                return size;
            }
            private set
            {
                size = value;
            }
        }
        public Node Head
        {
            get
            {
                return head;
            }
            private set
            {
                head = value;
            }
        }
        public Node Tail
        {
            get
            {
                return tail;
            }
            private set
            {
                tail = value;
            }
        }

        public CustomLinkedList()
        {
            this.size = 0;
            this.head = null;
            this.tail = null;
        }
        private bool isEmpty()
        {
            return Head == null;
        }

        public virtual void AddLast(int e)
        {
            Node newnode = new Node(e, null);
            if(isEmpty())
                this.head = newnode;
            else
                this.tail.Next = newnode;

            this.tail = newnode;
            this.size = this.size + 1;
        }

        public Node FindLast(int e)
        {
            Node node = this.head;
            while(node!=null)
            {
                if(node.Element==e)
                    return node;
                else
                    node = node.Next;
            }
            return null;

        }
        public virtual void AddFirst(int e)
        {
            Node newnode = new Node(e, null);
            if(isEmpty())
            {
                this.head = newnode;
                this.tail = newnode;
            }
            else
            {
                newnode.Next = this.head;
                this.head = newnode;
            }
            
            this.size = this.size + 1;
        }
        public virtual void AddAfter(Node n,int e)
        {
            Node newnode = new Node(e, null);
            newnode.Next = n.Next;
            n.Next = newnode;
            this.size = this.size + 1;
        }

        public virtual void RemoveFirst()
        {
            this.head = this.head.Next;
            this.size = this.size - 1;
        }

        public virtual void RemoveLast()
        {
            Node n = this.head;
            while(n!=null)
            {
                if(n.Next == this.tail)
                {
                    n.Next = null;
                    this.tail = n;
                    this.size = this.size - 1;
                }
                n = n.Next;
            }
        }
        public virtual void Remove(int e)
        {
            Node n = this.head;
            while (n != null)
            {
                if(n.Next.Element == e)
                {
                    n.Next = n.Next.Next;
                    this.size = this.size - 1;
                    break;
                }
                n = n.Next;
            }
        }
        public virtual void SortedInsert(int e)
        {
            Node newnode = new Node(e, null);
            Node current = this.head;
            Node previous = this.head;

            if (isEmpty())
                this.head = newnode;
            else
            {
                while(current != null && e >= current.Element) 
                {
                    previous = current;
                    current = current.Next;
                }
                if(current == this.head)
                {
                    newnode.Next = current;
                    this.head = newnode;
                }
                else
                {
                    newnode.Next = previous.Next;
                    previous.Next = newnode;
                }
                this.size = this.size + 1;
            }

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Node n = this.head;
            while(n!=null)
            {
                sb.Append(n.Element.ToString());
                n = n.Next;
                if(n!=null)
                    sb.Append(" -> ");
            }

            return sb.ToString();
        }
    }
}
