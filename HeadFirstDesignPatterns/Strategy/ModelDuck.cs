using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new QuackQuack();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
