using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Itenso.TimePeriod;

namespace PhotoperiodScheduler.Core
{
    public class Episode
    {
        public Time StartTime { get; set; }
        public Preset Preset { get; set; }

        public Episode()
        {
            //  Initialize to 12:00 AM upon creation
            StartTime = new Time(0, 0, 0, 0);
        }

        public bool HasPreset()
        {
            return (this.Preset != null);
        }
    }

    public class EpisodeComparer : Comparer<Episode>
    {
        public override int Compare(Episode x, Episode y)
        {
            if (x.StartTime < y.StartTime)
                return -1;
            else if (x.StartTime > y.StartTime)
                return 1;
            else
                return 0;
        }
    }
}
