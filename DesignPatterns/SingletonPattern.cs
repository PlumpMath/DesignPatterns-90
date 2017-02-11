using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class SingletonPattern
    {
        private static SingletonPattern instance = null;

        private SingletonPattern() { }

        public static SingletonPattern GetInstance()
        {
            if (instance == null)
                instance = new DesignPatterns.SingletonPattern();

            return instance;
        }
    }
}
