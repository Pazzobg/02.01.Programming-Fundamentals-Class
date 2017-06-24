using System;

namespace _03.Jarvis
{
    public class Arm
    {
        public int EnergyConsumption { get; set; }

        public int ArmReachDistance { get; set; }

        public int FingersCount { get; set; }

        public override string ToString()
        {
            return $"#Arm:{Environment.NewLine}###Energy consumption: {EnergyConsumption}{Environment.NewLine}" +
                $"###Reach: {ArmReachDistance}{Environment.NewLine}###Fingers: {FingersCount}";
        }
    }
}
