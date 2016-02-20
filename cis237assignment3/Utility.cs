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

        public Utility(string model, string material, string color, bool toolbox, bool computerConnection, bool arm) : base(model, material, color)
        {
            this.toolbox = toolbox;
            this.computerConnection = computerConnection;
            this.arm = arm;
        }

        public override string ToString()
        {
            return "Model: " + this.model + ", Material: " + this.material + ", Color: " + this.color + ", Toolbox: " + this.toolbox + 
                ", Computer Connection: " + this.computerConnection + ", Arm: " + this.arm;
        }

        public override void CalculateTotalCost()
        {
            // calculate totalCost by calculating the cost of each selected option and add it ot the base totalCost
        }
    }
}
