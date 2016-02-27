using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    abstract class Droid : IDroid
    {
        protected string material;
        protected string model;
        protected string color;
        protected decimal baseCost;
        protected decimal totalCost;

        public Droid(string model, string material, string color)
        {
            this.material = material;
            this.model = model;
            this.color = color;
        }

        public decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        public override string ToString()
        {
            return "Model: " + this.model + ", Material: " + this.material + ", Color: " + this.color;
        }

        // determine base cost based on material
        protected decimal CalculateBaseCost()
        {
            return baseCost;
        }
        
        // assigns baseCost to totalCost
        public virtual void CalculateTotalCost()
        {
            this.totalCost = this.baseCost;
        }
    }
}
