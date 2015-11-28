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
                Console.WriteLine(Fibo(i).ToString());        
            }

            Console.ReadLine();
        }

        static int Fibo(int index)
        {
            if (index == 0) return 0;
            if (index == 1) return 1;

            return Fibo(index - 1) + Fibo(index - 2);
        }
    }

}
