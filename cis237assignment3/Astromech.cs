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

        public Astromech(string material, string model, string color, bool toolbox, bool computerConnection, bool arm, bool fireExtinguisher, int numberShips) :
            base(material, model, color, toolbox, computerConnection, arm)
        {
            this.fireExtinguisher = fireExtinguisher;
            this.numberShips = numberShips;
        }

        public override string ToString()
        {
            return this.material + ", " + this.model + ", " + this.color + ", toolbox " + this.toolbox + ", computer connection " +
                this.computerConnection + ", arm " + this.arm + ", fire extinguisher " + this.fireExtinguisher + ", number of ships " + this.numberShips;
        }

        protected void CalculateTotalCost()
        {
            // Calculate totalCost by calculating the cost of each selected option and the cost based on the number of ships and adds both to the base CalculateTotalCost
        }
    }
}
