﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.FactoryMethod.Singleton
{
    public class OS
    {
        private static OS instance;

        public string Name { get; private set; }

        protected OS(string name) 
        {
            Name = name;
        }

        public static OS GetInstance(string name)
        {
            if (instance == null)
            {
                instance = new OS(name);
            }
            return instance;
        }
    }
}
