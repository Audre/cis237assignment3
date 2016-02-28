using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Astromech : Utility
    {
        protected bool fireExtinguisher;
        protected int numberShips;
        protected const int COST_PER_SHIP = 1;

        public Astromech(string model, string material, string color, bool toolbox, bool computerConnection, bool arm, bool fireExtinguisher, int numberShips) :
            base(model, material, color, toolbox, computerConnection, arm)
        {
            this.fireExtinguisher = fireExtinguisher;
            this.numberShips = numberShips;
        }

        public override string ToString()
        {
            return base.ToString() + ", Fire Extinguisher: " + this.fireExtinguisher + ", Number of Ships: " + this.numberShips;
        }

        public override void CalculateTotalCost()
        {
            base.CalculateBaseCost();
            base.CalculateTotalCost();
            base.totalCost = this.GetFireExtinguisherCost() + this.GetNumberShipsCost() + base.totalCost;
        }

        private decimal GetFireExtinguisherCost()
        {
            if (this.fireExtinguisher)
            {
                return 2;
            }

            else
            {
                return 0;
            }
        }

        private decimal GetNumberShipsCost()
        {
            return COST_PER_SHIP * this.numberShips;
        }
    }
}
