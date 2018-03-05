using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgrammer.HowLongHasTheLightBeenOn347
{
    internal class LightsOnCalculator
    {
    }

    internal class LightPeriod
    {
        public int StartTime { get; set; }
        public int EndTime { get; set; }
    }

    internal class Room
    {
        public List<LightPeriod> LightPeriods { get; set; }
    }
}
