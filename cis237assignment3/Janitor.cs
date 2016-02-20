using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Janitor : Utility
    {
        protected bool trashCompactor;
        protected bool vacuum;

        public Janitor(string model, string material, string color, bool toolbox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum) : 
            base(model, material, color, toolbox, computerConnection, arm)
        {
            this.trashCompactor = trashCompactor;
            this.vacuum = vacuum;
        }

        public override string ToString()
        {
            return "Model: " + this.model + ", Material: " + this.material + ", Color: " + this.color + ", Toolbox: " + this.toolbox + ", Computer Connection: " +
                this.computerConnection + ", Arm: " + this.arm + ", Trash Compactor: " + this.trashCompactor + ", Vacuum: " + this.vacuum;
        }

        public override void CalculateTotalCost()
        {
            // Calculate totalCost by calculating the cost of each selected option and adds it to the base totalCost
        }
    }
}
