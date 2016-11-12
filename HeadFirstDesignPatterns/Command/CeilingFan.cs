using System;

namespace Command
{
    class CeilingFan
    {
        public int Speed { get; set; }
        public string Name { get; private set; }
        public enum SpeedEnum
        {
            OFF,
            LOW,
            MEDIUM,
            HIGH
        }

        public CeilingFan(string name)
        {
            Name = name;
            Speed = 0;
        }

        internal void High()
        {
            Speed = (int)SpeedEnum.HIGH;
            Console.WriteLine($"{Name} ceiling fan speed set to high");
        }

        internal void Medium()
        {
            Speed = (int)SpeedEnum.MEDIUM;
            Console.WriteLine($"{Name} ceiling fan speed set to medium");
        }

        internal void Low()
        {
            Speed = (int)SpeedEnum.LOW;
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
