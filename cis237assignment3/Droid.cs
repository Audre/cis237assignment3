using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    abstract class Droid : IDroid
    {
        // Backing field.
        protected string material;
        protected string model;
        protected string color;
        protected decimal baseCost;
        protected decimal totalCost;

        // 3-parameter constructor.
        public Droid(string model, string material, string color)
        {
            this.model = model.ToLower();
            this.material = material.ToLower();
            this.color = color.ToLower();
        }

        // Property.
        public decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        // Overrides ToString() to display the droid base properties.
        public override string ToString()
        {
            CalculateBaseCost();
            CalculateTotalCost();
            return "Model: " + this.model + Environment.NewLine + "Material: " + this.material + Environment.NewLine + "Color: " + this.color;
        }

        // Calculates total cost of the base properties of a droid - the model, material, and color cost. 
        protected void CalculateBaseCost()
        {
            CalculateModelCost();
            this.baseCost = this.CalculateModelCost() + this.CalculateMaterialCost() + this.CalculateColorCost();
        }
        
        // Assigns baseCost to totalCost.
        public virtual void CalculateTotalCost()
        {
            this.totalCost = this.baseCost;
        }

        // Returns price for the model, depending on which model the user entered.
        protected decimal CalculateModelCost()
        {
            switch (this.model)
            {
                case "protocol":
                    {
                        return 1;
                    }

                case "utility":
                    {
                        return 2;
                    }

                case "janitor":
                    {
                        return 3;
                    }

                case "astromech":
                    {
                        return 4;
                    }

                default:
                    {
                        return 0;
                    }
            }
        }

        // Returns price for the material, depending on which material the user entered.
        private decimal CalculateMaterialCost()
        {
            switch (this.material)
            {
                case "wood":
                    {
                        return 1;
                    }

                case "cardboard":
                    {
                        return 2;
                    }

                case "metal":
                    {
                        return 3;
                    }

                default:
                    {
                        return 0;
                    }
            }
        }

        // Returns price for the color, depending on which color the user entered.
        private decimal CalculateColorCost()
        {
            switch (this.color)
            {
                case "red":
                    {
                        return 1;
                    }
                case "blue":
                    {
                        return 2;
                    }

                case "white":
                    {
                        return 3;
                    }

                case "black":
                    {
                        return 4;
                    }
                default:
                    {
                        return 0;
                    }
            }
        }
    }
}
