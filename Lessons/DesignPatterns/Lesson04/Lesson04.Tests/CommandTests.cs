﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson04.Tests
{
    [TestClass]
    public class CommandTests
    {
        [TestMethod]
        public void VolumeTest()
        {
            //var volume = new AquosCommand("VOLM", "30");
            //var volume2 = new AquosCommand("VOLM", 30);
            var volume2 = AquosCommand.Volume(30);

            //Assert.IsTrue(volume.ToString() == volume2.ToString());
        }

        [TestMethod]
        public void PowerTest()
        {
            //var power = new AquosCommand("POWR", "0");
            //var power2 = new AquosCommand("POWR", PowerSetting.Off);
            var power2 = AquosCommand.Power(PowerSetting.Off);

            //Assert.IsTrue(power.ToString() == power2.ToString());
        }
    }
}
