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
            SingleTone3 instance = SingleTone3.Instance;
        }
    }
    public class SingleTone3
    {
        private SingleTone3() { }

        private static readonly Object syncObject = new Object();
        private static SingleTone3 instance = null;
        public static SingleTone3 Instance
        { get
            {
                if (instance == null)
                lock (syncObject)
                {
                    if (instance == null)
                        instance = new SingleTone3();
                    return instance;
                }
                return instance
            }
        }
    }
}