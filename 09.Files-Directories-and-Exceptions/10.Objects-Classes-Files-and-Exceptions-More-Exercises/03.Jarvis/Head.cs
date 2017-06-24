using System;

namespace _03.Jarvis
{
    public class Head
    {
        public int EnergyConsumption { get; set; }

        public int Iq { get; set; }

        public string SkinMaterial { get; set; }

        public override string ToString()
        {
            return $"#Head: {Environment.NewLine}###Energy consumption: {EnergyConsumption}{Environment.NewLine}" +
                $"###IQ: {Iq}{Environment.NewLine}###Skin material: {SkinMaterial}";
        }
    }
}
