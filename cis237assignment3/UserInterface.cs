using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UserInterface
    {
        // Backing field.
        private string model;
        private bool isYes;
        private const int MENU_CHOICES = 3;

        // Properties.
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

        // Prompts user to enter model. Converts user input to all lower case and checks to make sure
        // user input is one of the options - protocol, utility, janitor, or astromech. If not one of the options,
        // will continue to prompt user until one of the options is entered. 
        public void GetModel()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter the model of the droid (protocol, utility, janitor, or astromech).");
            this.model = Console.ReadLine().ToLower();
            while  (this.model != "protocol" && this.model != "utility" && this.model != "janitor" && this.model != "astromech")
            {
                this.DisplayErrorMessage();
                Console.WriteLine("Please enter the model of the droid (protocol, utility, janitor, or astromech).");
                this.model = Console.ReadLine().ToLower();
            }

        }

        // Uses model to determine which methods to call to get the rest of the information for the droid and which overloaded method to pass
        // those arguments. 
        public void GetRestOfDroid(DroidCollection droidCollection)
        {
            switch (this.model)
            {
                case "protocol":
                    {
                        // Calls the methods required to get the rest of the information for the droid to call
                        // the AddDroid method, which creates a new instance of Protocol and adds it to the Droid array.
                        droidCollection.AddDroid(this.model, this.GetMaterial(), this.GetColor(), this.GetNumberLanguages());
                        break;
                    }

                case "utility":
                    {
                        // Calls the methods required to get the rest of the information for the droid to call
                        // the AddDroid method, which creates a new instance of Utility and adds it to the Droid array.
                        droidCollection.AddDroid(this.model, this.GetMaterial(), this.GetColor(), this.GetToolbox(), this.GetComputerConnection(), this.GetArm());
                        break;
                    }
                case "janitor":
                    {
                        // Calls the methods required to get the rest of the information for the droid to call
                        // the AddDroid method, which creates a new instance of Janitor and adds it to the Droid array.
                        droidCollection.AddDroid(this.model, this.GetMaterial(), this.GetColor(), this.GetToolbox(), this.GetComputerConnection(), 
                            this.GetArm(), this.GetTrashCompactor(), this.GetVacuum());
                        break;
                    }
                case "astromech":
                    {
                        // Calls the methods required to get the rest of the information for the droid to call
                        // the AddDroid method, which creates a new instance of Astromech and adds it to the Droid array.
                        droidCollection.AddDroid(this.model, this.GetMaterial(), GetColor(), this.GetToolbox(), this.GetComputerConnection(), this.GetArm(), 
                            this.GetFireExtinguisher(), this.GetNumberShips());
                        break;
                    }
            }
        }

        // Prompts user to enter material. Converts user input to all lower case and checks to make sure
        // user input is one of the options - wood, cardboard, or metal. If not one of the options,
        // will continue to prompt user until one of the options is entered. Returns material.
        private string GetMaterial()
        {
            string material;

            Console.WriteLine();
            Console.WriteLine("Please enter the type of material (wood, cardboard, or metal).");
            material = Console.ReadLine().ToLower();
            while (material != "wood" && material != "cardboard" && material != "metal")
            {
                this.DisplayErrorMessage();
                Console.WriteLine("Please enter the type of material (wood, cardboard, or metal).");
                material = Console.ReadLine().ToLower();
            }
            return material;
        }

        // Prompts user to enter color. Converts user input to all lower case and checks to make sure
        // user input is one of the options - red, blue, white, or black. If not one of the options,
        // will continue to prompt user until one of the options is entered. Returns color.
        private string GetColor()
        {
            string color;

            Console.WriteLine();
            Console.WriteLine("Please enter the color (red, blue, white, black).");
            color = Console.ReadLine().ToLower();
            while (color != "red" && color != "blue" && color != "white" && color != "black")
            {
                this.DisplayErrorMessage();
                Console.WriteLine("Please enter the color (red, blue, white, black).");
                color = Console.ReadLine().ToLower();
            }
            return color;
        }

        // Prompts user to enter number of languages. Checks to make sure user input is an integer. 
        // If not an integer, will continue to prompt user until one of the options is entered.
        private int GetNumberLanguages()
        {
            string userInput;
            int numberLanguages;

            Console.WriteLine();
            Console.WriteLine("Please enter the number of languages.");
            userInput = Console.ReadLine();
            while (!Int32.TryParse(userInput, out numberLanguages) || numberLanguages <= 0)
            {
                this.DisplayErrorMessage();
                Console.WriteLine("Please enter the number of languages.");
                userInput = Console.ReadLine();
            }
            return numberLanguages;
        }

        // Converts user input to lower case and checks if user input is one of the options
        // - y, yes, n, or no. If not one of the options, will continue to prompt user until 
        // one of the options is entered. If user enters y or yes, boolean is set to true, 
        // meaning the user wants the option on the droid. If user enters n or n, boolean is 
        //set to false, meaning the user does not want the option on the droid.
        private void InputCheck()
        {
            string userInput;
            userInput = Console.ReadLine();
            userInput = userInput.ToLower();
            while (userInput != "y" && userInput != "yes" && userInput != "n" && userInput != "no")
            {
                this.DisplayErrorMessage();
                Console.WriteLine("Please type y or n.");
                userInput = Console.ReadLine();
                userInput = userInput.ToLower();
            }

            if (userInput == "y" || userInput == "yes")
            {
                this.isYes = true;
            }
            else
            {
                this.isYes = false;
            }

        }

        // Prompts user to input choice for toolbox. Calls InputCheck() to 
        // make sure choice is either y, yes, n, or no and returns isYes as true
        // if entered y or yes (meaning the user wants the toolbox as an option)
        // or isYes returns false if entered n or no (meaning the user does not
        // want the toolbox as an option).
        private bool GetToolbox()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like a toolbox? y/n");
            this.InputCheck();
            return this.isYes;
        }

        // Prompts user to input choice for computer connection. Calls InputCheck() to 
        // make sure choice is either y, yes, n, or no and returns isYes as true
        // if entered y or yes (meaning the user wants the computer connection as an option)
        // or isYes returns false if entered n or no (meaning the user does not
        // want the computer connection as an option).
        private bool GetComputerConnection()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like a computer connection? y/n");
            this.InputCheck();
            return this.isYes;
        }

        // Prompts user to input choice for arm. Calls InputCheck() to 
        // make sure choice is either y, yes, n, or no and returns isYes as true
        // if entered y or yes (meaning the user wants the arm as an option)
        // or isYes returns false if entered n or no (meaning the user does not
        // want the arm as an option).
        private bool GetArm()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like an arm? y/n");
            this.InputCheck();
            return this.isYes;
        }

        // Prompts user to input choice for trash compactor. Calls InputCheck() to 
        // make sure choice is either y, yes, n, or no and returns isYes as true
        // if entered y or yes (meaning the user wants the toolbox as an option)
        // or isYes returns false if entered n or no (meaning the user does not
        // want the toolbox as an option).
        private bool GetTrashCompactor()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like a trash compactor? y/n");
            this.InputCheck();
            return this.isYes;
        }

        // Prompts user to input choice for vacuum. Calls InputCheck() to 
        // make sure choice is either y, yes, n, or no and returns isYes as true
        // if entered y or yes (meaning the user wants the vacuum as an option)
        // or isYes returns false if entered n or no (meaning the user does not
        // want the vacuum as an option).
        private bool GetVacuum()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like a vacuum? y/n");
            this.InputCheck();
            return this.isYes;
        }

        // Prompts user to input choice for fire extinguisher. Calls InputCheck() to 
        // make sure choice is either y, yes, n, or no and returns isYes as true
        // if entered y or yes (meaning the user wants the fire extinguisher as an option)
        // or isYes returns false if entered n or no (meaning the user does not
        // want the fire extinguisher as an option).
        private bool GetFireExtinguisher()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like a fire extinguisher? y/n");
            this.InputCheck();
            return this.isYes;
        }

        // Prompts user to enter number of languages. Checks to make sure user input is an integer. 
        // If not an integer, will continue to prompt user until one of the options is entered.
        private int GetNumberShips()
        {
            string userInput;
            int numberShips;
            Console.WriteLine();
            Console.WriteLine("Please enter the number of ships.");
            userInput = Console.ReadLine();

            while (!Int32.TryParse(userInput, out numberShips) || numberShips <= 0)
            {
                this.DisplayErrorMessage();
                Console.WriteLine("Please enter the number of ships.");
                userInput = Console.ReadLine();
            }

            return numberShips;
        }

        // Displays main menu of options to user.
        public void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("What would like you like to do?");
            Console.WriteLine("   1. Add New Droid.");
            Console.WriteLine("   2. Print Droid List.");
            Console.WriteLine("   3. Exit.");
            Console.WriteLine();
        }

        // Gets user choice from main menu. Checks to make sure the choice is a 
        // a number between 1 and 3. If not, it will continue to print an error
        // message and the main menu until a correct choice is made. 
        public int GetUserChoice()
        {
            string userSelection;
            int choice;
            userSelection = Console.ReadLine();
            Int32.TryParse(userSelection, out choice);

            while (choice <= 0 || choice > MENU_CHOICES)
            {
                this.DisplayErrorMessage();
                this.PrintMenu();
                userSelection = Console.ReadLine();
                Int32.TryParse(userSelection, out choice);
            }

            return choice;
        }

        // Lets user know input was not a valid choice.
        public void DisplayErrorMessage()
        {
            Console.WriteLine();
            Console.WriteLine("This is not a valid choice.");
        }

    }
}
