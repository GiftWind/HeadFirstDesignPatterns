using System;

namespace Adapter
{
    class DuckTest
    {
        static void Main(string[] args)
        {
            MallardDuck duck = new MallardDuck();

            WildTurkey turkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The Turkey says:");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("\nThe Duck says:");
            duck.Quack();
            duck.Fly();

            Console.WriteLine("\nThe Turkey Adapter says:");
            TestDuck(turkeyAdapter);

            Console.ReadLine();
        }

        private static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
