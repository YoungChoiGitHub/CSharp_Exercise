using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglelyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
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

    public class LinkedList<T>
    {
        Node<T> _headNode;
        public LinkedList()
        {
            _headNode = new Node<T>();
        }

        public bool Add(T value)
        {
            Node<T> node = _headNode;
            while (node.Next != null)
            {
                node = node.Next;
            }
            node.Next = new Node<T>(value);
            return true;
        }

        public bool Update(T sValue, T dValue)
        {
            Node<T> node = _headNode;
            while (!node.Content.Equals(sValue) && node.Next != null) 
            {
                node = node.Next;
            }

	    if (node.Next == null) return false;

            node.Content = dValue;
            return true;
        }

        public bool Delete(T value)
        {
            Node<T> prevNode = _headNode;
            Node<T> curNode = _headNode.Next;
            while (!curNode.Content.Equals(value) && curNode.Next != null)
            {
                prevNode = curNode;
                curNode = curNode.Next;
            }
            if (curNode.Content.Equals(value))
            {
                prevNode.Next = curNode.Next;
                return true;
            }
            else
                return false;
        }

        public void TraverseReverse()
        {
            Node<T> curNode = _headNode;

            if (curNode.Next == null) return;

            while (curNode.Next != null)
            {
                curNode = curNode.Next;
            }
            traverseReverse(curNode);
        }
        private void traverseReverse(Node<T> endNode)

        {
            Node<T> curNode = _headNode.Next;
            Node<T> prevNode = _headNode;

            if (endNode == _headNode)
                return;

            while (curNode != endNode)
            {
                prevNode = curNode;
                curNode = curNode.Next;
            }
            Console.WriteLine(curNode.Content.ToString());
            traverseReverse(prevNode);
        }

        public void Print()
        {
            Node<T> node = _headNode.Next;
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
