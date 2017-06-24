using System;

namespace _03.Jarvis
{
    public class Torso
    {
        public int EnergyConsumption { get; set; }

        public double ProcessorSize { get; set; }

        public string HousingMaterial { get; set; }

        public override string ToString()
        {
            return $"#Torso: {Environment.NewLine}###Energy consumption: {EnergyConsumption}{Environment.NewLine}" +
                $"###Processor size: {ProcessorSize:f1}{Environment.NewLine}###Corpus material: {HousingMaterial}";
        }
    }
}
