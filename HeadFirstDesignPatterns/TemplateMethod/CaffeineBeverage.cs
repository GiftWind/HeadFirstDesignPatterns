using System;

namespace TemplateMethod
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCUp();
            AddCondiments();
        }

        void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        internal abstract void Brew();

        void PourInCUp()
        {
            Console.WriteLine("Pouring into cup");
        }

        internal abstract void AddCondiments();
    }
}
