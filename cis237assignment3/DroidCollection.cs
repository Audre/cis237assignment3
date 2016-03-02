using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class DroidCollection
    {
        // Backing field.
        private Droid[] droids;
        private int index = 0;
        
        // 1-parameter constructor.
        public DroidCollection(int size)
        {
            // Makes new instace of object Droid array with size passed in.
            droids = new Droid[size];
        }

        // Property.
        protected int Index
        {
            get { return index; }
            set { index = value; }
        }

        // Overloaded method that adds a new instance of Protocol to the Droid array. 
        public void AddDroid(string model, string material, string color, int numberLanguages)
        {
            droids[index] = new Protocol(model, material, color, numberLanguages);
            index++;
        }

        // Overloaded method that adds a new instance of Utility to the Droid array.
        public void AddDroid(string model, string material, string color, bool toolbox, bool computerConnection, bool arm)
        {
            droids[index] = new Utility(model, material, color, toolbox, computerConnection, arm);
            index++;
        }

        // Overloaded method that adds a new instance of Janitor to the Droid array.
        public void AddDroid(string model, string material, string color, bool toolbox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum)
        {
            droids[index] = new Janitor(model, material, color, toolbox, computerConnection, arm, trashCompactor, vacuum);
            index++;
        }

        // Overloaded method that adds a new instance of Astromech to the Droid array.
        public void AddDroid(string model, string material, string color, bool toolbox, bool computerConnection, bool arm, bool fireExtinguisher, int numberShips)
        {
            droids[index] = new Astromech(model, material, color, toolbox, computerConnection, arm, fireExtinguisher, numberShips);
            index++;
        }

        // Overrides ToString() that displays all the droids in the Droid array and the total cost for each droid -
        // goes through each element in the Droid array and adds  to droidConcat the ToString() for the type of droid (protocol,
        // utility, janitor, or astromech) and the TotalCost from the Droid class 
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
                    droidConcat += Environment.NewLine + droid.ToString() + Environment.NewLine + "Total Cost: " +  droid.TotalCost.ToString("C") + Environment.NewLine;
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
