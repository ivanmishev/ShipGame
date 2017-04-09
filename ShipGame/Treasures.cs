using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipGame
{
    public enum ChestType { small, large };

    class Treasures
    {
        private string chestType;
        public string type { get { return chestType; } set { this.chestType = value; } }
        public Treasures(ChestType type)
        {
            this.type = type.ToString();
        }
    }
}
