using PhotoperiodScheduler.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Itenso.TimePeriod;

namespace PhotoperiodScheduler.Core.Test
{
    [TestClass()]
    public class ScheduleTest
    {
        private string scheduleName = "Schedule 1";
 
        [TestMethod()]
        public void ScheduleConstructor_DefineName_ScheduleNameMatchesInitName()
        {
            Schedule target = new Schedule(scheduleName);
            Assert.AreEqual(target.Name, scheduleName);
        }

        [TestMethod()]
        public void ScheduleConstructor_DefineName_EpisodeListIsNotNull()
        {
            Schedule target = new Schedule(scheduleName);
            Assert.IsNotNull(target.GetEpisodes());
        }

        [TestMethod()]
        public void AddEpisode_NewSchedule_EpisodeCountIs1()
        {
            Schedule target = new Schedule(scheduleName);
            Episode e = new Episode();

            target.AddEpisode(e);

            Assert.AreEqual(target.GetEpisodes().Count, 1);
        }

        [TestMethod()]
        public void RemoveEpisode_ScheduleContains1Episode_EpisodeCountIs0()
        {
            Schedule target = new Schedule(scheduleName);
            Episode e = new Episode();

            target.AddEpisode(e);
            target.RemoveEpisode(e);

            Assert.AreEqual(target.GetEpisodes().Count, 0);
        }

        [TestMethod()]
        public void ClearEpisode_ScheduleContains2Episodes_EpisodeCountIs0()
        {
            Schedule target = new Schedule(scheduleName);

            target.AddEpisode(new Episode());
            target.AddEpisode(new Episode());
            target.AddEpisode(new Episode());
            target.ClearEpisodes();

            Assert.AreEqual(target.GetEpisodes().Count, 0);
        }

        [TestMethod()]
        public void AddEpisode_NewSchedule_HasEpisodesisTrue()
        {
            Schedule target = new Schedule(scheduleName);

            target.AddEpisode(new Episode());

            Assert.IsTrue(target.HasEpisodes());
        }
    }
}
