namespace Command
{
    class StereoOnWithCDCommand : ICommand
    {
        public Stereo Stereo { get; private set; }

        public StereoOnWithCDCommand(Stereo stereo)
        {
            Stereo = stereo;
        }

        public void Execute()
        {
            Stereo.On();
            Stereo.SetCD();
            // TODO: set default volume without magic constant
            Stereo.SetVolume(11);
        }
    }
}
