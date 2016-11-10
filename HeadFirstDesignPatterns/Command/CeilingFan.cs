using System;

namespace Command
{
    class CeilingFan
    {
        internal void High()
        {
            Console.WriteLine("Ceiling fan speed set to high");
        }

        internal void Medium()
        {
            Console.WriteLine("Ceiling fan speed set to medium");
        }

        internal void Low()
        {
            Console.WriteLine("Ceiling fan speed set to low");
        }

        internal void Off()
        {
            Console.WriteLine("Ceiling fan off");
        }

    }
}
