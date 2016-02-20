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

            ui.GetModel();
            ui.GetRestOfDroid(droidCollection);
            Console.WriteLine(droidCollection.ToString());
        }
    }
}
