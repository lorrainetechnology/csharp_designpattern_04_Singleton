using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SingletonDesignPattern
{
    public class ThreadSafeDC_Singleton
    {
        static ThreadSafeDC_Singleton instance;
        private static object locker = new object();

        protected ThreadSafeDC_Singleton()
        {

        }

        public static ThreadSafeDC_Singleton Instance()
        {
            //Thread safe, double checked locking pattern
            if (instance == null)
            {
                lock(locker)
                {
                    if(instance == null)
                        instance = new ThreadSafeDC_Singleton();
                }
            }
                
            return instance;
        }
    }
}
