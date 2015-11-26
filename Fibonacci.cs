using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }

        private static int Fibonacci(int index)
        {
            int a = 0; 
            int b = 1;
            for (int i = 0; i < index; i++)
            {
                int temp = a;
                a = b;
                b = a + temp;
            }
            return a;
        }
    }
}
