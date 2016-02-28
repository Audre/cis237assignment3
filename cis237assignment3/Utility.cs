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
            return base.ToString() + ", Toolbox: " + this.toolbox + ", Computer Connection: " + this.computerConnection + ", Arm: " + this.arm;
        }

        public override void CalculateTotalCost()
        {
            base.CalculateBaseCost();
            base.CalculateTotalCost();
            base.totalCost =  this.GetToolboxCost() + GetComputerConnectionCost() + GetArmCost()+ base.totalCost;
        }

        private decimal GetToolboxCost()
        {
            if (this.toolbox)
            {
                return 2;
            }

            else
            {
                return 0;
            }
        }

        private decimal GetComputerConnectionCost()
        {
            if (this.computerConnection)
            {
                return 2;
            }

            else
            {
                return 0;
            }
        }

        private decimal GetArmCost()
        {
            if (this.arm)
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
