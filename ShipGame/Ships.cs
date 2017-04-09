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
        private bool destroyed = false;
        private int quadrants;

        public bool Destroyed { get { return destroyed; } set { this.destroyed = value; } }
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
                this.quadrants = 1;
            }
            else if (shipType == ShipType.medium)
            {
                this.shipName = "rookie ship";
                this.quadrants = 2;
            }
            else if (shipType == ShipType.large)
            {
                this.shipName = "general ship";
                this.quadrants = 3;
            }
            else if (shipType == ShipType.huge)
            {
                this.shipName = "captain ship";
                this.quadrants = 4;
            }
        }
    }
}
