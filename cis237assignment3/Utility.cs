using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Utility : Droid
    {
        // Backing field.
        protected bool toolbox;
        protected bool computerConnection;
        protected bool arm;

        // 6-parameter constructor - 3 are passed to the parent's (Droid) constructor: model, material, and color.
        public Utility(string model, string material, string color, bool toolbox, bool computerConnection, bool arm) : base(model, material, color)
        {
            this.toolbox = toolbox;
            this.computerConnection = computerConnection;
            this.arm = arm;
        }

        // Overrides ToString() to display the droid properties - uses the parent's ToString() (from Droid) to display model, material, and color. 
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Toolbox: " + this.toolbox + Environment.NewLine + "Computer Connection: " + 
                this.computerConnection + Environment.NewLine + "Arm: " + this.arm;
        }

        // Calculates total cost of an utility droid. Calls the parent CalculateBaseCost (from Droid).
        // Droid.CalculateBaseCost() calculates the cost for the model, material, and color and adds that to Droid.totalCost. This.CaculateBaseCost() 
        // (from the child) then calculates the cost for the toolbox, computer connection, and arm, then adds the amount to Droid.totalCost.
        public override void CalculateTotalCost()
        {
            base.CalculateBaseCost();
            base.CalculateTotalCost();
            base.totalCost =  this.GetToolboxCost() + GetComputerConnectionCost() + GetArmCost()+ base.totalCost;
        }

        // Returns price for toolbox based on if user chose to have a toolbox or not.
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

        // Returns price for computer connection based on if user chose to have a computer connection or not.
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

        // Returns price for arm based on if user chose to have an arm or not.
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
