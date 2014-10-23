using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Itenso.TimePeriod;
using PhotoperiodScheduler.Core;

namespace PhotoperiodScheduler.Core.Test
{
    [TestClass()]
    public class EpisodeTest
    {
        [TestMethod()]
        public void EpisodeConstructor_NoArgs_StartTimeIs12AM()
        {
            Episode target = new Episode();
            Time expected = new Time();
            Assert.AreEqual<Time>(target.StartTime, expected);
            System.Diagnostics.Debug.WriteLine("New Episode start time:  " + target.StartTime.ToString());
        }

        [TestMethod()]
        public void SetPreset_NewEpisode_EpisodePresetMatchesCreatedPreset()
        {
            Episode target = new Episode();
            Preset p = new Preset("Sunset", "HW_UP");

            Preset actual;
            target.Preset = p;
            actual = (Preset)target.Preset;
            Assert.AreEqual(p, actual);
        }

        [TestMethod()]
        public void SetStartTime_EpisodeIsNew_GetStartTimeReturnsExpectedTime()
        {
            Episode target = new Episode();
            Time expected = new Time(21, 34, 53, 20);
            Time actual;
            target.StartTime = expected;
            actual = target.StartTime;
            Assert.AreEqual(expected, actual);
            System.Diagnostics.Debug.WriteLine("SetStartTime_EpisodeIsNew_GetStartTimeReturnsExpectedTime Time:  " + target.StartTime.ToString());
        }

        [TestMethod]
        public void HasPreset_NoPresetAssigned_ReturnsFalse()
        {
            Episode e = new Episode();

            Assert.IsFalse(e.HasPreset());
        }

        [TestMethod]
        public void HasPreset_PresetAssigned_ReturnsTrue()
        {
            Episode e = new Episode();
            Preset p = new Preset("Sunrise", "YUERIPR");

            e.Preset = p;

            Assert.IsTrue(e.HasPreset());
        }
    }
}
