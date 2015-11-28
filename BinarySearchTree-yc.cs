using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(50);
            bst.Insert(33);
            bst.Insert(21);
            bst.Insert(55);
            bst.Insert(9);
            bst.Insert(13);
            bst.Insert(5);
            bst.Insert(57);
            bst.PrintTree();

            bst.Search(5);
            Console.ReadLine();
        }

       
    }

    class BinarySearchTree
    {
        private Node _rootNode { get; set; }
        public BinarySearchTree()
        {
            _rootNode = new Node();
        }
        public void Insert(int value)
        {
            Node curNode = _rootNode;
            if (curNode.Content == 0)
            {
                curNode.Content = value;
            }

            insertNode(curNode, value);
        }

        private void insertNode(Node curNode, int value)
        {
            Node newNode = new Node(value);
            if (curNode.Content > value)
            {
                if (curNode.Left == null)
                {
                    curNode.Left = newNode;
                }
                else
                {
                    insertNode(curNode.Left, value);
                }
            }
            else if (curNode.Content == value)
                return;
            else  // curNode.Content < value
            {
                if (curNode.Right == null)
                    curNode.Right = newNode;
                else
                    insertNode(curNode.Right, value);
            }
        }

        public bool Search(int value)
        {
            Node node = _rootNode;
            Console.WriteLine("Node = " + node.Content.ToString());
            if (node.Content == value)
            {
                Console.WriteLine("Content = " + node.Content.ToString());
                return true;
            }
            else if (node.Content > value)
                return searchNode(node.Left, value);
            else
                return searchNode(node.Right, value);
        }

        private bool searchNode(Node node, int value)
        {
            if (node == null) return false;

            Console.WriteLine("Node = " + node.Content.ToString());
            if (node.Content == value)
            {
                Console.WriteLine("Content = " + node.Content.ToString());
                return true;
            }
            else if (node.Content > value)
                return searchNode(node.Left, value);
            else // node.Content < value
                return searchNode(node.Right, value);
        }

        public void PrintTree()
        {
            printSubtree(_rootNode);
        }
        private void printSubtree(Node node)
        {
            if (node == null) return;

            printSubtree(node.Left);
            Console.WriteLine(node.Content.ToString());
            printSubtree(node.Right);
        }
    }

}
