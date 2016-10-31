using System;

namespace Strategy
{
    public class SimUDuck
    {
        public static void Main()
        {

            Duck duck1 = new MallardDuck();
            Duck duck2 = new ModelDuck();

            duck1.Display();
            duck1.Swim();
            duck1.PerformQuack();
            duck1.PerformFly();

            Console.WriteLine();

            duck2.Display();
            duck2.Swim();
            duck2.PerformQuack();
            duck2.PerformFly();
            duck2.FlyBehavior = new FlyRocketPowered();
            duck2.PerformFly();


            Console.ReadKey();
        }
    }
}
