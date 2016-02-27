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

            while (choice != 3)
            {
                switch (choice)
                {
                    case 1:
                        {
                            ui.GetModel();
                            ui.GetRestOfDroid(droidCollection);
                            break;
                        }

                    case 2:
                        {
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
