using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5.StrategyPattern;

namespace ConsoleApp5.StrategyPattern
{
    public class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Start electric car");
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
