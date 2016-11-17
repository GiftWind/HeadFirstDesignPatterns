using System;

namespace TemplateMethod
{
    public class Coffee : CaffeineBeverage
    {
        internal override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter.");
        }

        internal override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk.");
        }
    }
}
