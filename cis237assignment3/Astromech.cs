using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Astromech : Utility
    {
        // Backing field.
        protected bool fireExtinguisher;
        protected int numberShips;
        protected const int COST_PER_SHIP = 1;

        // 8-parameter constructor - 6 are passed to the parent's (Utility) constructor: model, material, color, toolbox, computerConnection, and arm. 
        // Model, material, and color are then passed to Utility's parent's (Droid) constructor.  
        public Astromech(string model, string material, string color, bool toolbox, bool computerConnection, bool arm, bool fireExtinguisher, int numberShips) :
            base(model, material, color, toolbox, computerConnection, arm)
        {
            this.fireExtinguisher = fireExtinguisher;
            this.numberShips = numberShips;
        }

        // Overrides ToString() to display the droid properties - uses the parent's ToString() (from Utility) to display toolbox, computer connection, and arm 
        // and uses Utility's parent class ToString() (from Droid) to display model, material, and color. 
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Fire Extinguisher: " + this.fireExtinguisher + Environment.NewLine + "Number of Ships: " + this.numberShips;
        }

        // Calculates total cost of an astromech droid. Calls the parent CalculateBaseCost (from Utility), which calls its parent CalculateBaseCost (from Droid). 
        // Droid.CalculateBaseCost() calculates the cost for the model, material, and color and adds that to Droid.totalCost and 
        // Utility.CalculateBaseCost() calculates the cost for the toolbox, computer connection, and arm and adds that amount to Droid.totalCost. This.CaculateBaseCost() 
        // (from the child) then calculates the cost for the fire extinguisher and number of ships and then adds the amount to Droid.totalCost.
        public override void CalculateTotalCost()
        {
            base.CalculateBaseCost();
            base.CalculateTotalCost();
            base.totalCost = this.GetFireExtinguisherCost() + this.GetNumberShipsCost() + base.totalCost;
        }

        // Returns price for fire extinguisher based on if user chose to have a fire extinguisher or not.
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
        
        // Returns price for number of ships, depending on the number of ships the user entered.
        private decimal GetNumberShipsCost()
        {
            return COST_PER_SHIP * this.numberShips;
        }
    }
}
