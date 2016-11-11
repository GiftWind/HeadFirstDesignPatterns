using System;

namespace Command
{
    class CeilingFan
    {
        public string Name { get; private set; }

        public CeilingFan(string name)
        {
            Name = name;
        }

        internal void High()
        {
            Console.WriteLine($"{Name} ceiling fan speed set to high");
        }

        internal void Medium()
        {
            Console.WriteLine($"{Name} ceiling fan speed set to medium");
        }

        internal void Low()
        {
            Console.WriteLine($"{Name} ceiling fan speed set to low");
        }

        internal void On()
        {
            Console.WriteLine($"{Name} ceiling fan is on");
        }

        internal void Off()
        {
            Console.WriteLine($"{Name} ceiling fan off");
        }

    }
}
