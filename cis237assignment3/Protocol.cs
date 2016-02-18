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

        public Protocol(string material, string model, string color, int numberLanguages) : base(material, model, color)
        {
            this.numberLanguages = numberLanguages;
        }

        public override string ToString()
        {
            return this.material + " " + this.model + " " + this.color + " " + this.numberLanguages + " " + COST_PER_LANGUAGE.ToString("C");
        }

        protected void CaclulateTotalCost()
        {
            this.totalCost = this.numberLanguages * COST_PER_LANGUAGE;
        }

    }
}
