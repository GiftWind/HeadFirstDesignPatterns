namespace Command
{
    class StereoOffCommand : ICommand
    {
        public Stereo Stereo { get; private set; }

        public StereoOffCommand(Stereo stereo)
        {
            Stereo = stereo;
        }

        public void Execute()
        {
            Stereo.Off();
        }
    }
}
