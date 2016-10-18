using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class SimUDuck
    {
        static void Main(string[] args)
        {
            MallardDuck Duck1 = new MallardDuck();
            RedheadDuck Duck2 = new RedheadDuck();

            Duck1.Display();
            Duck1.Quack();
            Duck1.Swim();

            Duck2.Display();
            Duck2.Quack();
            Duck2.Swim();
            
            Console.ReadKey();
        }
    }

    abstract class Duck
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }

        public void Swim()
        {
            Console.WriteLine("I'm swimming");
        }

        public abstract void Display();


    }

    class MallardDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I'm mallard duck");
        }
    }

    class RedheadDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I'm a redhead duck");
        }
    }
}
