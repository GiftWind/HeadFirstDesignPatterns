using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class CeilingFanHighCommand : ICommand
    {
        public CeilingFan CeilingFan { get; private set; }

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            CeilingFan = ceilingFan;
        }

        public void Execute()
        {
            CeilingFan.High();
        }
    }
}
