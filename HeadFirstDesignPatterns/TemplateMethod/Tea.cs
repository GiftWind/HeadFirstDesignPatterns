using System;

namespace TemplateMethod
{
    public class Tea : CaffeineBeverage
    {
        internal override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon.");
        }

        internal override void Brew()
        {
            Console.WriteLine("Steeping the tea.");
        }
    }
}
