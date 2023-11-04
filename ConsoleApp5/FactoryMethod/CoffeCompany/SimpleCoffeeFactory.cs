using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.FactoryMethod.CoffeCompany
{
    public class SimpleCoffeeFactory
    {
        public Coffee CreateCoffee(CoffeeType coffeeType)
        {
            Coffee coffee = null;

            switch (coffeeType)
            {
                case CoffeeType.Americano:
                    coffee = new Ammericano();
                    break;
                case CoffeeType.Espresso:
                    coffee = new Espresso();
                    break;
                case CoffeeType.Cappuccino:
                    coffee = new Cappuccino();
                    break;
            }

            return coffee;
        }
    }
}
