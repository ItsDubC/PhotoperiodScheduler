using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhotoperiodScheduler.Core;

namespace PhotoperiodScheduler.Core.Test
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class PresetTest
    {
        [TestMethod]
        public void PresetConstructor_NecessaryArgs_ReturnsProperArgs()
        {
            string presetName = "Rolling Cloud Cover";
            string rollingCloudCoverIrCode = "0x20DF58A7";

            Preset p = new Preset(presetName, rollingCloudCoverIrCode);

            Assert.AreEqual(p.Name, presetName);
            Assert.AreEqual(p.IrCode, rollingCloudCoverIrCode);
        }

        [TestMethod]
        public void IsValid_NonEmptynameWithNonEmptyIrCode_ReturnsTrue()
        {
            Preset p = new Preset("Dawn", "0x20DF58A7");
            Assert.IsTrue(p.IsValid());
        }

        [TestMethod]
        public void IsValid_NonEmptyNameWithEmptyIrCode_ReturnsFalse()
        {
            Preset p = new Preset("Dusk", string.Empty);
            Assert.IsFalse(p.IsValid());
        }

        [TestMethod]
        public void IsValid_EmptyNameWithNonEmptyIrCode_ReturnsFalse()
        {
            Preset p = new Preset(null, "TYUIPGFD");
            Assert.IsFalse(p.IsValid());
        }

        [TestMethod]
        public void IsValid_EmptyNameWithEmptyIrCode_ReturnsFalse()
        {
            Preset p = new Preset("", string.Empty);
            Assert.IsFalse(p.IsValid());
        }
    }
}
