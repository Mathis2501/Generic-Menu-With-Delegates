using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMenuWithDelegates
{
    class Program
    {
        static void Main()
        {
            Menu mainMenu = new Menu("Main Menu");
            mainMenu.ConstructMenu("Create Costumer", mainMenu.CreateCustomer);
            mainMenu.ConstructMenu("EXIT", mainMenu.ExitApplication);
            mainMenu.Show();
        }

        
    }
}
