using System;
using System.IO;

namespace TemplateMethod
{
    class CoffeeWithHook : CaffeineBeverageWithHook
    {
        internal override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk.");
        }

        internal override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter.");
        }

        public override bool CustomerWantsCondiments()
        {
            string answer = GetUserInput();

            if (answer.ToLower().StartsWith("y", StringComparison.Ordinal))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //TODO: refactor this part
        string GetUserInput()
        {
            string answer = null;

            Console.WriteLine("Would you like milk and sugar with your coffee (y/n)?");
            try
            {
                answer = Console.ReadLine();
            }
            catch (IOException ioe)
            {
                Console.WriteLine("IO Exception trying to read you answer");
            }
            if (answer == null)
            {
                return "no";
            }
            return answer;
        }
    }
}
