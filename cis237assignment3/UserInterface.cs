using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UserInterface
    {
        private string model;
        private bool isYes;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public bool IsYes
        {
            get { return isYes; }
            set { isYes = value; }
        }

        public void GetModel()
        {
            Console.WriteLine("Please enter the model of the droid (protocol, utility, janitor, or astromech).");
            this.model = Console.ReadLine();
            
        }

        public void GetRestOfDroid(DroidCollection droidCollection)
        {
            switch (this.model.ToLower())
            {
                case "protocol":
                    {
                        droidCollection.AddDroid(this.model, GetMaterial(), GetColor(), GetNumberLanguages());
                        break;
                    }

                case "utility":
                    {
                        // string model, string material, string color, bool toolbox, bool computerConnection, bool arm)
                        droidCollection.AddDroid(this.model, GetMaterial(), GetColor(), GetToolbox(), GetComputerConnection(), GetArm());
                        break;
                    }
                case "janitor":
                    {
                        // string model, string material, string color, bool toolbox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum)
                        // call janitor
                        droidCollection.AddDroid(this.model, GetMaterial(), GetColor(), GetToolbox(), GetComputerConnection(), GetArm(), GetTrashCompactor(), GetVacuum());
                        break;
                    }
                case "astromech":
                    {
                        // string model, string material, string color, bool toolbox, bool computerConnection, bool arm, bool fireExtinguisher, int numberShips)
                        // call astromech
                        droidCollection.AddDroid(this.model, GetMaterial(), GetColor(), GetToolbox(), GetComputerConnection(), GetArm(), GetFireExtinguisher(), GetNumberShips());
                        break;
                    }
            }
        }

        private string GetMaterial()
        {
            string material;

            Console.WriteLine("Please enter the type of material (wood, cardboard, or metal).");
            material = Console.ReadLine();
            if (material != "wood" || material != "cardboard" || material != "metal")
            {
                Console.WriteLine("That is not a valid option.");
                return GetMaterial();
            }
            return material;
        } 

        private string GetColor()
        {
            string color; 

            Console.WriteLine("Please enter the color (red, blue, white, black).");
            return color = Console.ReadLine();
        }

        private int GetNumberLanguages()
        {
            string userInput;
            int numberLanguages;

            Console.WriteLine("Please enter the number of languages.");
            userInput = Console.ReadLine();
            Int32.TryParse(userInput, out numberLanguages);
            return numberLanguages;
        }

        private void InputCheck()
        {
            string userInput;
            userInput = Console.ReadLine();
            userInput = userInput.ToLower();
            if (userInput == "y" || userInput == "yes")
            {
                this.isYes = true;
            }
            else if (userInput == "n" || userInput == "no")
            {
                this.isYes = false;
            }
            else
            {
                Console.WriteLine("That was not a valid input. Please type y or n.");
                InputCheck();
            }
            

        }

        // string model, string material, string color, bool toolbox, bool computerConnection, bool arm)

        private bool GetToolbox()
        { 
            Console.WriteLine("Would you like a toolbox? y/n");
            InputCheck();
            return isYes;
        }

        private bool GetComputerConnection()
        {
            Console.WriteLine("Would you like a computer connection? y/n");
            InputCheck();
            return isYes;
        }

        private bool GetArm()
        {
            Console.WriteLine("Would you like an arm? y/n");
            InputCheck();
            return isYes;
        }

        // string model, string material, string color, bool toolbox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum)

        private bool GetTrashCompactor()
        {
            Console.WriteLine("Would you like a trash compactor? y/n");
            InputCheck();
            return isYes;
        }

        private bool GetVacuum()
        {
            Console.WriteLine("Would you like a vacuum? y/n");
            InputCheck();
            return isYes;
        }

        //string model, string material, string color, bool toolbox, bool computerConnection, bool arm, bool fireExtinguisher, int numberShips)

        private bool GetFireExtinguisher()
        {
            Console.WriteLine("Would you like a fire extinguisher? y/n");
            InputCheck();
            return isYes;
        }

        private int GetNumberShips()
        {
            string userInput;
            int numberShips;

            Console.WriteLine("Please enter the number of ships.");
            userInput = Console.ReadLine();
            Int32.TryParse(userInput, out numberShips);
            return numberShips;
        }

    }
}
