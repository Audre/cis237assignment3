using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class DroidCollection
    {
        private Droid[] droids;
        private int index = 0;
        
        public DroidCollection(int size)
        {
            droids = new Droid[size];
        }

        protected int Index
        {
            get { return index; }
            set { index = value; }
        }

        public void AddDroid(string model, string material, string color, int numberLanguages)
        {
            droids[index] = new Protocol(model, material, color, numberLanguages);
            index++;
        }

        public void AddDroid(string model, string material, string color, bool toolbox, bool computerConnection, bool arm)
        {
            droids[index] = new Utility(model, material, color, toolbox, computerConnection, arm);
            index++;
        }

        public void AddDroid(string model, string material, string color, bool toolbox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum)
        {
            droids[index] = new Janitor(model, material, color, toolbox, computerConnection, arm, trashCompactor, vacuum);
            index++;
        }

        public void AddDroid(string model, string material, string color, bool toolbox, bool computerConnection, bool arm, bool fireExtinguisher, int numberShips)
        {
            droids[index] = new Astromech(model, material, color, toolbox, computerConnection, arm, fireExtinguisher, numberShips);
            index++;
        }

        public override string ToString()
        {
            bool isEmpty = true;
            string droidConcat = String.Empty;
            foreach(Droid droid in droids)
            {
                if (droid != null)
                {
                    droid.CalculateTotalCost();
                    isEmpty = false;
                    droidConcat += droid.ToString() + ", Total Cost: " + droid.TotalCost + Environment.NewLine;
                }
            }

            if (isEmpty)
            {
                return "There are no droids.";
            }
            else
            {
                return droidConcat;
            }
        }
    }
}
