using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Protocol : Droid
    {
        protected int numberLanguages;
        protected const decimal COST_PER_LANGUAGE = 5;

        public Protocol(string model, string material, string color, int numberLanguages) : base(model, material, color)
        {
            this.numberLanguages = numberLanguages;
        }

        public override string ToString()
        {
            return base.ToString() + ", " + "Number of Languages: " + this.numberLanguages;
        }

        public override void CalculateTotalCost()
        {
            base.CalculateBaseCost();
            base.CalculateTotalCost();
            base.totalCost = this.GetNumberLanguagesCost() + base.totalCost;
        }

        private decimal GetNumberLanguagesCost()
        {
            return COST_PER_LANGUAGE * this.numberLanguages;
        }

    }
}
