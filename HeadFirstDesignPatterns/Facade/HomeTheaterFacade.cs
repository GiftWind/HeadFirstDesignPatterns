﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class HomeTheaterFacade
    {
        Amplifier _amp;
        Tuner _tuner;
        DvdPlayer _dvd;
        CdPlayer _cd;
        Projector _projector;
        TheaterLights _lights;
        Screen _screen;
        PopcornPopper _popper;

        public HomeTheaterFacade(Amplifier amp,
                            Tuner tuner,
                            DvdPlayer dvd,
                            CdPlayer cd,
                            Projector projector,
                            TheaterLights lights,
                            Screen screen,
                            PopcornPopper popper)
        {
            _amp = amp;
            _tuner = tuner;
            _dvd = dvd;
            _cd = cd;
            _projector = projector;
            _lights = lights;
            _screen = screen;
            _popper = popper;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie");
            _popper.On();
            _popper.Pop();
            _lights.Dim(10);
            _screen.Down();
            _projector.On();
            _projector.WideScreenMode();
            _amp.On();
            _amp.SetSurroundSound();
            _amp.SetVolume(10);
            _dvd.On();
            _dvd.PlayMovie(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down");
            _popper.Off();
            _lights.On();
            _screen.Up();
            _projector.Off();
            _amp.Off();
            _dvd.Stop();
            _dvd.Eject();
            _dvd.Off();
        }

    }
}
