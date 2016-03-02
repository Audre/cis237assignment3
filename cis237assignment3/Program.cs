using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface ui = new UserInterface();
            DroidCollection droidCollection = new DroidCollection(100);

            ui.PrintMenu();
            int choice = ui.GetUserChoice();

            // If user choice is 3, the program will exit. Otherwise, menu will keep displaying. 
            while (choice != 3) 
            {
                switch (choice)
                {
                    case 1:
                        {
                            // Allows user to enter a new droid. 
                            ui.GetModel();
                            ui.GetRestOfDroid(droidCollection);
                            break;
                        }

                    case 2:
                        {
                            // Displays all droids user has entered that are in the droid array.
                            Console.WriteLine(droidCollection.ToString());
                            break;
                        }
                }

                ui.PrintMenu();
                choice = ui.GetUserChoice();
            }

            
            
        }
    }
}
