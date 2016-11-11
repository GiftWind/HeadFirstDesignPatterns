namespace Command
{
    class StereoOnWithCDCommand : ICommand
    {
        Stereo _stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.On();
            _stereo.SetCD();
            // TODO: set default volume without magic constant
            _stereo.SetVolume(11);
        }
    }
}
