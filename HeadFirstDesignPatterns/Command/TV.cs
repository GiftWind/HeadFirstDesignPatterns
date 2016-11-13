using System;

namespace Command
{
    class TV
    {
        public string Name { get; private set; }

        public TV(string name)
        {
            Name = name;
        }

        internal void On()
        {
            Console.WriteLine($"{Name} TV is on");
        }

        internal void Off()
        {
            Console.WriteLine($"{Name} TV is off");
        }

    }
}