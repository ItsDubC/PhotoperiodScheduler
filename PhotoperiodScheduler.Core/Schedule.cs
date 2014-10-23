using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoperiodScheduler.Core
{
    public class Schedule
    {
        public string Name { get; set; }

        private List<Episode> episodes;

        public Schedule(string name)
        {
            Name = name;
            episodes = new List<Episode>();
        }

        public List<Episode> GetEpisodes()
        {
            return episodes;
        }

        public void AddEpisode(Episode e)
        {
            episodes.Add(e);
            this.SortEpisodes();
        }

        public void RemoveEpisode(Episode e)
        {
            episodes.Remove(e);
            this.SortEpisodes();
        }

        public void ClearEpisodes()
        {
            episodes.Clear();
        }

        public bool HasEpisodes()
        {
            return (episodes.Count > 0);
        }

        private void SortEpisodes()
        {
            episodes.Sort(new EpisodeComparer());
        }
    }

    //public class Schedule : TimePeriodChain
    //{
    //    public string Name { get; set; }

    //    public Schedule(string name) : base()
    //    {
    //        Name = name;
    //    }

    //    public Schedule(string name, int numPhotoperiods) : base()
    //    {
    //        Name = name;

    //        long ticksInADay = new TimeSpan(24, 0, 0).Ticks;
    //        long ticksInEachPhotoperiod = ticksInADay / numPhotoperiods;
    //        long ticksCurrent = 0;

    //        for (int i = 1; i < numPhotoperiods+1; i++)
    //        {
    //            this.Add(new Photoperiod(i.ToString(), new DateTime(ticksCurrent), new DateTime(ticksCurrent + ticksInEachPhotoperiod)));
    //            ticksCurrent += ticksInEachPhotoperiod;
    //        }

    //        //  Adjust end time of last photoperiod so that entire duration of schedule equals 24 hrs
    //        Photoperiod lastPhotoperiod = (Photoperiod)this.Last();

    //        if (lastPhotoperiod.End.Ticks != ticksInADay)
    //        {
    //            lastPhotoperiod.End = new DateTime(ticksInADay- new TimeSpan(0, 0, 1).Ticks);
    //        }
    //    }
    //}
}