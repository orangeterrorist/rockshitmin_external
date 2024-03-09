using System;
using Rock.Menus;

namespace Rock
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Start();
        }
    }
}
