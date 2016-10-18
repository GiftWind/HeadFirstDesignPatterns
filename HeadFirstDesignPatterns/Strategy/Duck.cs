using System;

namespace Strategy
{

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

        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }

        public abstract void Display();


    }
}
