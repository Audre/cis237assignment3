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
            return base.ToString() + ", Trash Compactor: " + this.trashCompactor + ", Vacuum: " + this.vacuum;
        }

        public override void CalculateTotalCost()
        {
            base.CalculateBaseCost();
            base.CalculateTotalCost();
            base.totalCost = this.GetTrashCompactorCost() + this.GetVacuumCost() + base.totalCost;
        }

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
