using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HornetArmada
{
    public class Legion
    {
        public string Name { get; set; }

        public int LastActivity { get; set; }

        public Dictionary<string, long> SoldiersTypes { get; set; }
    }
}
