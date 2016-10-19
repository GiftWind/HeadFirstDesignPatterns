using System;

namespace Strategy
{

    class RedheadDuck : Duck
    {

        public RedheadDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new QuackQuack();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a redhead duck");
        }
    }
}
