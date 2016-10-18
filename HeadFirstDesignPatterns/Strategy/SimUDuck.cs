using System;

namespace Strategy
{
    class SimUDuck
    {
        static void Main(string[] args)
        {
            MallardDuck Duck1 = new MallardDuck();
            RedheadDuck Duck2 = new RedheadDuck();
            RubberDuck Duck3 = new RubberDuck();

            Duck1.Display();
            Duck1.Quack();
            Duck1.Swim();
            Duck1.Fly();
            Console.WriteLine();

            Duck2.Display();
            Duck2.Quack();
            Duck2.Swim();
            Duck2.Fly();
            Console.WriteLine();

            Duck3.Display();
            Duck3.Quack();
            Duck3.Swim();
            Duck3.Fly();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
