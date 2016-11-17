using System;

namespace TemplateMethod
{
    public abstract class CaffeineBeverageWithHook
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        internal abstract void Brew();
        internal abstract void AddCondiments();

        void BoilWater()
        {
            Console.WriteLine("Boiling Waater.");
        }

        void PourInCup()
        {
            Console.WriteLine("Pouring into cup.");
        }

        public virtual bool CustomerWantsCondiments()
        {
            return true;
        }
    }
}
