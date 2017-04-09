using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipGame
{
    public enum ShipType { small, medium, large, huge };
    class Ships
    {
        public string shipName; 
        private string[] shipPosition; 
        private ShipType _shipType;

        public ShipType ShipType { get ; set; }
        public string[] ShipPosition { get {return shipPosition; } set { } }
        public string ShipName { get { return shipName; } set { } }

        public Ships(ShipType shipType, string[] shipPosition)
        {
            this._shipType = shipType;
            this.shipPosition = shipPosition;
            if(shipType == ShipType.small)
            {
                this.shipName = "peasant boat";
            }
            else if (shipType == ShipType.medium)
            {
                this.shipName = "rookie ship";
            }
            else if (shipType == ShipType.large)
            {
                this.shipName = "general ship";
            }
            else if (shipType == ShipType.huge)
            {
                this.shipName = "captain ship";
            }
        }
    }
}
