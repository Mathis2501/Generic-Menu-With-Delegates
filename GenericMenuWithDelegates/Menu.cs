using System;
using System.Collections.Generic;

namespace GenericMenuWithDelegates
{
    public delegate void OnMenuChosen();
    class Menu
    {
        private List<MenuItem> MenuItemsList;
        private string MenuName;
        private string ErrorMessage;
        private bool ShowMenu;
        private OnMenuChosen _onMenuChosen;

        internal Menu(string menuName)
        {
            MenuItemsList = new List<MenuItem>();
            MenuName = menuName;
            ErrorMessage = "";
            ShowMenu = true;
        }

        public void ConstructMenu(string MenuItemName, OnMenuChosen MenuMethodToRun)
        {
            MenuItem a = new MenuItem();
            a.MenuItemName = MenuItemName;
            a.MenuChosen = new OnMenuChosen(MenuMethodToRun);
            MenuItemsList.Add(a);
        }

        public void Show()
        {
            for(int i = 0; i < MenuItemsList.Count; i++)
            {
                Console.WriteLine(i + 1 + ": " +  MenuItemsList[i].MenuItemName);
            }
            int MenuChosen;
            if (int.TryParse(Console.ReadLine(), out MenuChosen))
            {
                if (MenuChosen - 1 < MenuItemsList.Count)
                {
                    MenuItemsList[MenuChosen - 1].MenuChosen();
                }

                else
                {
                    Console.WriteLine("That was not a valid option");
                    Show();
                }
                
            }
            else
            {
                Console.WriteLine("That was not a valid option");
                Show();
            }
            
            
        }

        internal void CreateCustomer()
        {
            throw new NotImplementedException();
        }
        public void ExitApplication()
        {
            Environment.Exit(0);
        }

        class MenuItem
        {
            public string MenuItemName;
            public OnMenuChosen MenuChosen;
        }


        
    }
}
