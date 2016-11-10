using System;

namespace Command
{
    internal class Light
    {
        public string Name { get; private set; }

        public Light(string v)
        {
            Name = v;
        }

        internal void On()
        {
            Console.WriteLine($"{Name} light is On");
        }

        internal void Off()
        {
            Console.WriteLine($"{Name} light is off");
        }
    }
}