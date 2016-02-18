using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Utility : Droid
    {
        protected bool toolbox;
        protected bool computerConnection;
        protected bool arm;

        public Utility(string material, string model, string color, bool toolbox, bool computerConnection, bool arm) : base(material, model, color)
        {
            this.toolbox = toolbox;
            this.computerConnection = computerConnection;
            this.arm = arm;
        }

        public override string ToString()
        {
            return this.material + ", " + this.model + ", " + this.color + ", toolbox " + this.toolbox + ", computer connection " + this.computerConnection + ", arm " + this.arm;
        }

        protected void CalculateTotalCost()
        {
            // calculate totalCost by calculating the cost of each selected option and add it ot the base totalCost
        }
    }
}
