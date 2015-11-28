using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Print();

            list.Update(2, 5);
            list.Print();

            list.Delete(3);
            list.Print();

            list.TraverseReverse();

            Console.ReadLine();
        }
    }

    public class LinkedList
    {
        Node _headNode;
        public LinkedList()
        {
            _headNode = new Node();
        }

        public bool Add(int value)
        {
            Node curNode = _headNode;
            while (curNode.Next != null)
            {
                curNode = curNode.Next;
            }

            Node newNode = new Node(value);
            curNode.Next = newNode;
            newNode.Prev = curNode;

            return true;
        }

        public bool Update(int sValue, int dValue)
        {
            Node curNode = _headNode.Next;
            while (curNode.Content != sValue && curNode.Next != null) 
            {
                curNode = curNode.Next;
            }

            if (curNode.Next == null) return false;

            curNode.Content = dValue;
            return true;
        }

        public bool Delete(int value)
        {
            Node curNode = _headNode.Next;
            while (curNode.Content != value && curNode.Next != null)
            {
                curNode = curNode.Next;
            }
            if (curNode.Content == value)
            {
                curNode.Prev.Next = curNode.Next;
                curNode.Next.Prev = curNode.Prev;
                return true;
            }
            else
                return false;
        }

        public void TraverseReverse()
        {
            Node curNode = _headNode;

            if (curNode.Next == null) return;

            while (curNode.Next != null)
            {
                curNode = curNode.Next;
            }
            while (curNode != _headNode)
            {
                Console.WriteLine("Content: {0}", curNode.Content.ToString());
                curNode = curNode.Prev;
            }
        }

        public void Print()
        {
            Node node = _headNode.Next;
            while (node.Next != null)
            {
                Console.WriteLine("Contents value: {0}", node.Content.ToString());
                node = node.Next;
            }
            Console.WriteLine("Contents value: {0}", node.Content.ToString());
            Console.WriteLine("----------------------------");
        }

    }
}
