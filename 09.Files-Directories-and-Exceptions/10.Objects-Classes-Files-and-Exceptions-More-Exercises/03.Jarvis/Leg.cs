using System;

namespace _03.Jarvis
{
    public class Leg
    {
        public int EnergyConsumption { get; set; }

        public int Strength { get; set; }

        public int Speed { get; set; }

        public override string ToString()
        {
            return $"#Leg: {Environment.NewLine}###Energy consumption: {EnergyConsumption}{Environment.NewLine}" +
                $"###Strength: {Strength}{Environment.NewLine}###Speed: {Speed}";
        }
    }
}
