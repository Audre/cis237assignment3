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
            return "Model: " + this.model + ", " + " Material: " + this.material + ", " + "Color: " + this.color + ", " + "Number of Languages: " + this.numberLanguages;
        }

        public override void CalculateTotalCost()
        {
            //this.totalCost = this.numberLanguages * COST_PER_LANGUAGE;
        }

    }
}
