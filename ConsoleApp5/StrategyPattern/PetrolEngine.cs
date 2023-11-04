using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.StrategyPattern
{
    public class PetrolEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("start petrol car");
        }
    }
}
