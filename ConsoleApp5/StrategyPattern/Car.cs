using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.StrategyPattern
{
    public class Car
    {
        public static string Model { get; set; }

        private IEngine _engine;

        public Car(string model, IEngine engine)
        {
            Model = model;
            _engine = engine;
        }

        public void Move()
        {
            _engine.Start();
        }
    }
}
