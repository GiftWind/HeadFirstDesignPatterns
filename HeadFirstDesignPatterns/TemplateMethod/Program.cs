using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeWithHook cwh = new CoffeeWithHook();
            Console.WriteLine("Preparing coffee");
            cwh.PrepareRecipe();
            Console.ReadLine();

        }
    }
}
