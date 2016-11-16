using System;

namespace TemplateMethod
{
    public class Coffee
    {
        public void PrepareRecipe()
        {
            BoilWater();
            BrewCoffeeGrinds();
            PourInCup();
            AddSugarAndMilk();
        }

        void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        void BrewCoffeeGrinds()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        void PourInCup()
        {
            Console.WriteLine("Pouring ino cup");
        }

        void AddSugarAndMilk()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }
    }
}
