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
            this.model = model.ToLower();
            this.material = material.ToLower();
            this.color = color.ToLower();
        }

        public decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        public override string ToString()
        {
            CalculateBaseCost();
            CalculateTotalCost();
            return "Model: " + this.model + ", Material: " + this.material + ", Color: " + this.color;
        }

        // determine base cost based on material
        protected void CalculateBaseCost()
        {
            CalculateModelCost();
            this.baseCost = this.CalculateModelCost() + this.CalculateMaterialCost() + this.CalculateColorCost();
        }
        
        // assigns baseCost to totalCost
        public virtual void CalculateTotalCost()
        {
            this.totalCost = this.baseCost;
        }

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
