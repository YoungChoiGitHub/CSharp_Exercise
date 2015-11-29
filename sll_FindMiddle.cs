using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;

            SinglelyLinkedList list = new SinglelyLinkedList();
            if (!list.findMiddleNode(out index))
                Console.WriteLine("There is no item in the list!");
            list.Add(1);
            if (!list.findMiddleNode(out index))
                Console.WriteLine("There is no item in the list!");
            else
                Console.WriteLine("Middle index = " + index.ToString());
            list.Add(2);
            if (!list.findMiddleNode(out index))
                Console.WriteLine("There is no item in the list!");
            else
                Console.WriteLine("Middle index = " + index.ToString());

            list.Add(3);
            if (!list.findMiddleNode(out index))
                Console.WriteLine("There is no item in the list!");
            else
                Console.WriteLine("Middle index = " + index.ToString());

            list.Add(4);
            list.Add(5);
            if (!list.findMiddleNode(out index))
                Console.WriteLine("There is no item in the list!");
            else
                Console.WriteLine("Middle index = " + index.ToString());


            Console.ReadLine();
        }
    }

    class SinglelyLinkedList
    {
        Node _headNode;
        public SinglelyLinkedList()
        {
            _headNode = new Node();
        }

        public void Add(int value)
        {
            Node curNode = _headNode;
            Node newNode = new Node(value);

            while (curNode.Next != null)
                curNode = curNode.Next;
            curNode.Next = newNode; 
        }

        public bool findMiddleNode(out int index)
        {
            index = 0;
            if (_headNode.Next == null) return false;

            Node curNode = _headNode.Next;
            while (curNode.Next != null)
            {
                curNode = curNode.Next;
                index++;
            }
            index /= 2;
            return true;                
        }
    }


}
