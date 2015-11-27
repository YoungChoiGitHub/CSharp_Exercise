using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleTone1 instance = SingleTone1.Instance;
        }
    }
    public class SingleTone1
    {
        private SingleTone1() { }

        private static SingleTone1 instance = null;
        public static SingleTone1 Instance
        { get
            {
                if (instance == null)
                    instance = new SingleTone1();
                return instance;
            }
        }
    }
}