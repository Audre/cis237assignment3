using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Protocol : Droid
    {
        // Backing field.
        protected int numberLanguages;
        protected const decimal COST_PER_LANGUAGE = 5m;

        // 4-parameter constructor - 3 are passed the parent's (Droid) constructor: model, material, and color. 
        public Protocol(string model, string material, string color, int numberLanguages) : base(model, material, color)
        {
            this.numberLanguages = numberLanguages;
        }

        // Overrides ToString() to display the droid properties - uses the parent's ToString() (from Droid) to display model, material, and color. 
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Number of Languages: " + this.numberLanguages;
        }

        // Calculates total cost of a protocol droid. Calls the parent CalculateBaseCost (from Droid).
        // Droid.CalculateBaseCost() calculates the cost for the model, material, and color and adds that to Droid.totalCost. This.CaculateBaseCost() 
        // (from the child) then calculates the cost for the number of languages, then adds the amount to Droid.totalCost.
        public override void CalculateTotalCost()
        {
            
            base.CalculateBaseCost();
            base.CalculateTotalCost();
            base.totalCost = this.GetNumberLanguagesCost() + base.totalCost;
        }

        // Returns price for number of languages, depending on the number of language the user entered.
        private decimal GetNumberLanguagesCost()
        {
            return COST_PER_LANGUAGE * this.numberLanguages;
        }

    }
}
