using System;

namespace Strategy
{
    class SimUDuck
    {
        static void Main()
        {

            Duck Duck1 = new MallardDuck();
            Duck Duck2 = new ModelDuck();

            Duck1.Display();
            Duck1.Swim();
            Duck1.PerformQuack();
            Duck1.PerformFly();

            Console.WriteLine();

            Duck2.Display();
            Duck2.Swim();
            Duck2.PerformQuack();
            Duck2.PerformFly();
            Duck2.FlyBehavior = new FlyRocketPowered();
            Duck2.PerformFly();


            Console.ReadKey();
        }
    }
}
