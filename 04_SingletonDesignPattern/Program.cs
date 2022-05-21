using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SingletonDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            if (s1 == s2)
                Console.WriteLine("Singleton Objects are of the same intance\n");

            ThreadSafeDC_Singleton ts1 = ThreadSafeDC_Singleton.Instance();
            ThreadSafeDC_Singleton ts2 = ThreadSafeDC_Singleton.Instance();
            ThreadSafeDC_Singleton ts3 = ThreadSafeDC_Singleton.Instance();

            if (ts1 == ts2 && ts2 == ts3)
                Console.WriteLine("ThreadSafeDC_Singleton Objects are of the same intance\n");

            Console.ReadKey();
        }
    }
}
