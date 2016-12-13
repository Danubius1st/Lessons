using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05.Core
{
    public abstract class ComputerBuilder
    {
        protected readonly Computer _computer = new Computer();
        public abstract void SetCores();
        public abstract void SetCpuFrequency();
        public abstract void SetRam();
        public abstract void SetDriveType();
        public virtual Computer GetComputer()
        {
            return _computer;
        }
    }
}
