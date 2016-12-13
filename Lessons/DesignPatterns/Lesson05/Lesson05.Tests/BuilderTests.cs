using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using Lesson05.Core;

namespace Lesson05.Tests
{
    [TestClass]
    public class BuilderTests
    {
        [TestMethod]
        public void SuperComputer()
        {
            //StringBuilder str = new StringBuilder();

            //str.Append("hello");
            //str.Append(' ');
            //str.Append("world");

            //Assert.IsTrue(str.ToString() == "hello world");

            var computer = new Computer
            {
                AmountOfCores = 64,
                AmountOfRam = 256,
                CpuFrequency = 3.4m,
                DriveType = "ssd"
            };

            var store = new HandyDandyComputerStore();
            var builder = new SuperComputerBuilder();

            store.Build(builder);

            builder.SetCores();
            builder.SetRam();
            builder.SetCpuFrequency();
            builder.SetDriveType();

            var superComputer = builder.GetComputer();
            Assert.AreEqual(superComputer.AmountOfCores, computer.AmountOfCores);
            Assert.AreEqual(superComputer.AmountOfRam, computer.AmountOfRam);
            Assert.AreEqual(superComputer.CpuFrequency, computer.CpuFrequency);
            Assert.AreEqual(superComputer.DriveType, computer.DriveType);
        }

        [TestMethod]
        public void NoSoSuperComputer()
        {
            //StringBuilder str = new StringBuilder();

            //str.Append("hello");
            //str.Append(' ');
            //str.Append("world");

            //Assert.IsTrue(str.ToString() == "hello world");

            var computer = new Computer
            {
                AmountOfCores = 1,
                AmountOfRam = 2,
                CpuFrequency = 2.0m,
                DriveType = "hdd"
            };

            var store = new HandyDandyComputerStore();
            var builder = new NotSoSuperComputerBuilder();

            store.Build(builder);

            builder.SetCores();
            builder.SetRam();
            builder.SetCpuFrequency();
            builder.SetDriveType();

            var superComputer = builder.GetComputer();
            Assert.AreEqual(superComputer.AmountOfCores, computer.AmountOfCores);
            Assert.AreEqual(superComputer.AmountOfRam, computer.AmountOfRam);
            Assert.AreEqual(superComputer.CpuFrequency, computer.CpuFrequency);
            Assert.AreEqual(superComputer.DriveType, computer.DriveType);
        }
    }
}
