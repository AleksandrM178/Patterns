using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.FactoryMethod.CoffeCompany
{
    public abstract class  Coffee
    {
        public abstract void GrindCoffe();
        public abstract void MakeCoffe();
        public abstract void PourCoffe();
    }
}
