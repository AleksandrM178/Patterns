using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.FactoryMethod.CoffeCompany
{
    public class CoffeShop
    {
        private readonly SimpleCoffeeFactory _simpleCoffeeFactory;

        public CoffeShop(SimpleCoffeeFactory simpleCoffeeFactory) 
        {
            _simpleCoffeeFactory = simpleCoffeeFactory;
        }

        public Coffee OrderCoffee(CoffeeType coffeeType)
        {
            Coffee coffee = _simpleCoffeeFactory.CreateCoffee(coffeeType);

            coffee.GrindCoffe();
            coffee.MakeCoffe();
            coffee.PourCoffe();

            Console.WriteLine("Coffee is ready");
            return coffee;
        }
    }
}
