using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.FactoryMethod.Singleton
{
    public class Logger
    {
        private static Logger instance;

        private Logger() { }

        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }
        }

        public void LogInfo(string msg)
        {
            Console.WriteLine(msg);
        }

        public void LogWarning(string msg)
        {
            Console.WriteLine(msg);
        }

        public void LogError(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
