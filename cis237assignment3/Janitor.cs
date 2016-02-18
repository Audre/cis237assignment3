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

        public Janitor(string material, string model, string color, bool toolbox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum) : 
            base(material, model, color, toolbox, computerConnection, arm)
        {
            this.trashCompactor = trashCompactor;
            this.vacuum = vacuum;
        }

        public override string ToString()
        {
            return this.material + ", " + this.model + ", " + this.color + ", toolbox " + this.toolbox + ", computer connection " +
                this.computerConnection + ", arm " + this.arm + ", trash compactor " + this.trashCompactor + ", vacuum " + this.vacuum;
        }

        protected void CalculateTotalCost()
        {
            // Calculate totalCost by calculating the cost of each selected option and adds it to the base totalCost
        }
    }
}
