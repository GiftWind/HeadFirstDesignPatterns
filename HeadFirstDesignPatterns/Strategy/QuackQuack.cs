using System;

namespace Strategy
{
    public class QuackQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("QuackQuack");
        }
    }
}
