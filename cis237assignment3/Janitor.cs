using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Janitor : Utility
    {
        // Backing field.
        protected bool trashCompactor;
        protected bool vacuum;

        // 8-parameter constructor - 6 are passed to the parent's (Utility) constructor: model, material, color, toolbox, computerConnection, and arm. 
        // Model, material, and color are then passed to Utility's parent's (Droid) constructor. 
        public Janitor(string model, string material, string color, bool toolbox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum) : 
            base(model, material, color, toolbox, computerConnection, arm)
        {
            this.trashCompactor = trashCompactor;
            this.vacuum = vacuum;
        }

        // Overrides ToString() to display the droid properties - uses the parent's ToString() (from Utility) to display toolbox, computer connection, and arm 
        // and uses Utility's parent class ToString() (from Droid) to display model, material, and color. 
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Trash Compactor: " + this.trashCompactor + Environment.NewLine + "Vacuum: " + this.vacuum;
        }

        // Calculates total cost of a janitor droid. Calls the parent CalculateBaseCost (from Utility), which calls its parent CalculateBaseCost (from Droid). 
        // Droid.CalculateBaseCost() calculates the cost for the model, material, and color and adds that to Droid.totalCost and 
        // Utility.CalculateBaseCost() calculates the cost for the toolbox, computer connection, and arm and adds that amount to Droid.totalCost. This.CaculateBaseCost() 
        // (from the child) then calculates the cost for the trash compactor and vacuum and then adds the amount to Droid.totalCost.
        public override void CalculateTotalCost()
        {
            base.CalculateBaseCost();
            base.CalculateTotalCost();
            base.totalCost = this.GetTrashCompactorCost() + this.GetVacuumCost() + base.totalCost;
        }

        // Returns price for trash compactor based on if user chose to have a trash compactor or not.
        private decimal GetTrashCompactorCost()
        {
            if (this.trashCompactor)
            {
                return 2;
            }

            else
            {
                return 0;
            }
        }

        // Returns price for vacuum based on if user chose to have a vacuum or not.
        private decimal GetVacuumCost()
        {
            if (this.vacuum)
            {
                return 2;
            }

            else
            {
                return 0;
            }
        }
    }
}
