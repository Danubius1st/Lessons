using System;

namespace Lesson06
{
    public class Computer : ICloneable
    {
        public int AmountOfCores { get; set; }
        public decimal CpuFrequency { get; set; }
        public int AmountOfRam { get; set; }
        public string DriveType { get; set; }
        public GraphicsCard Gpu { get; set; }

        public object Clone()
        {
            //return MemberwiseClone();
            var clone = (Computer) MemberwiseClone();
            //clone.Gpu = new GraphicsCard
            //{
            //    AmountOfRam = Gpu.AmountOfRam,
            //    GpuFrequency = Gpu.GpuFrequency
            //};
            clone.Gpu = (GraphicsCard)Gpu.Clone();
            return clone;
        }
    }
}
