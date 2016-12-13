﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05.Core
{
    public class SuperComputerBuilder : ComputerBuilder
    {
        //private readonly Computer _computer = new Computer();

        public override void SetCores()
        {
            _computer.AmountOfCores = 64;
        }

        public override void SetCpuFrequency()
        {
            _computer.CpuFrequency = 3.4m;
        }

        public override void SetRam()
        {
            _computer.AmountOfRam = 256;
        }

        public override void SetDriveType()
        {
            _computer.DriveType = "ssd";
        }

        //public Computer GetComputer()
        //{
        //    return _computer;
        //}
    }
}
