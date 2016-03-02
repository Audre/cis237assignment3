using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    interface IDroid
    {
        // Since Droid implements IDroid, Droid must have a CalculateTotalCost() method and a TotalCost property. 
        void CalculateTotalCost();

        decimal TotalCost { get; set; }
    }
}
