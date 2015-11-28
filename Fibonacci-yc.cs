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
            for (int i = 1; i < 15; i++)
            {
                Console.WriteLine(FibonacciSeries(i).ToString());        
            }

            Console.ReadLine();
        }

        static int FibonacciSeries(int index)
        {
            int first = 0;
            int second = 1;
            int temp = 0;

            for (int i = 0; i < index; i++)
            {
                temp = first;
                first = second;
                second = temp + second;
            }
            return first;
        }
    }

}
