using System;

namespace Strategy
{

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new QuackQuack();
        }
        public override void Display()
        {
            Console.WriteLine("I'm mallard duck");
        }
    }
}
