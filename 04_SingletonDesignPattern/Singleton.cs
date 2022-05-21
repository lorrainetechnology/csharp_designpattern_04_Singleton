using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SingletonDesignPattern
{
    public class Singleton
    {
        static Singleton instance;

        protected Singleton()
        {

        }

        public static Singleton Instance()
        {
            //Lazy initialization - not thread safe
            if(instance == null)
                instance = new Singleton();
            return instance;
        }
    }
}
