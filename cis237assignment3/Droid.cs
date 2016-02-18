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

        public Droid(string material, string model, string color)
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
            return this.material + " " + this.model + " " + this.color + " " + this.baseCost.ToString("C") + " " + this.totalCost.ToString("C");
        }

        protected decimal CalculateBaseCost()
        {
            return baseCost;
        }

        public void CalculateTotalCost()
        {
            baseCost = totalCost;
        }
    }
}
