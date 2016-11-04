using System;

namespace Decorator
{
    class StarBuzzCoffeeShop
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            beverage = new Mocha(beverage);
            Console.WriteLine(beverage.GetDescription() + ", $" + beverage.GetCost() );

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.GetDescription() + ", $" + beverage2.GetCost());

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.GetDescription() + ", $" + beverage3.GetCost());

            Console.ReadLine();


        }
    }
}
