using System;

namespace Command
{
    public class Stereo
    {
        public string Name { get; private set; }

        public Stereo(string name)
        {
            Name = name;
        }

        internal void On()
        {
            Console.WriteLine("Stereo is On");
        }

        internal void Off()
        {
            Console.WriteLine("Stereo is off");
        }

        internal void SetCD()
        {
            Console.WriteLine("Stereo is set for CD");
        }

        internal void SetRadio()
        {
            Console.WriteLine("Stereo is set for radio");
        }

        internal void SetVolume(int v)
        {
            Console.WriteLine($"Stereo volume set to {v}");
        }
    }
}