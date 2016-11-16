using System;

namespace TemplateMethod
{
    public class Tea
    {
        public void PrepareRecipe()
        {
            BoilWater();
            SteepTeaBag();
            PourInCup();
            AddLemon();
        }

        void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        void SteepTeaBag()
        {
            Console.WriteLine("Steeping the tea");
        }

        void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        void AddLemon()
        {
            Console.WriteLine("Adding Lemon");
        }
    }
}
