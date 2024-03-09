using System;
using Colorful;
using Rock.Extensions;
using Rock.Mods;
using Photon.Pun;

namespace Rock.Menus
{
    public class MiscMenu
    {
        public void Start()
        {
            this.RunMiscMenu();
        }

        private void RunMiscMenu()
        {
            System.Console.Title = "neptuneq | ShitminCheat (Miscellaneous)";
            string prompt = "\r\n-==========================================================================================================-\r\n\r\n                                    ___    ___                                                     \r\n /'\\_/`\\  __                       /\\_ \\  /\\_ \\                                                    \r\n/\\      \\/\\_\\    ____    ___     __\\//\\ \\ \\//\\ \\      __      ___      __    ___   __  __    ____  \r\n\\ \\ \\__\\ \\/\\ \\  /',__\\  /'___\\ /'__`\\\\ \\ \\  \\ \\ \\   /'__`\\  /' _ `\\  /'__`\\ / __`\\/\\ \\/\\ \\  /',__\\ \r\n \\ \\ \\_/\\ \\ \\ \\/\\__, `\\/\\ \\__//\\  __/ \\_\\ \\_ \\_\\ \\_/\\ \\L\\.\\_/\\ \\/\\ \\/\\  __//\\ \\L\\ \\ \\ \\_\\ \\/\\__, `\\\r\n  \\ \\_\\\\ \\_\\ \\_\\/\\____/\\ \\____\\ \\____\\/\\____\\/\\____\\ \\__/.\\_\\ \\_\\ \\_\\ \\____\\ \\____/\\ \\____/\\/\\____/\r\n   \\/_/ \\/_/\\/_/\\/___/  \\/____/\\/____/\\/____/\\/____/\\/__/\\/_/\\/_/\\/_/\\/____/\\/___/  \\/___/  \\/___/ \r\n                                                                                                  \r\n                                                                                                   \r\n\r\n-==========================================================================================================-                                                                                   \r\nWelcome to ShitminCheat.WTF a Client built for Modding/Hacking RecRoom in any kind of Rec Room verisons";
            string[] options = new string[]
            {
                "Gifting",
                "Photon Host",
                "Nothing",
                "Misc Menu",
                "Exit",
            };
            MenuController menuController = new MenuController(prompt, options);
            int num = menuController.Run();
            menuController.DisplayOptions();
            switch (num)
            {
                case 0:
                    this.FirstChoice();
                    break;
                case 1:
                    MiscMenu.SecondChoice();
                    break;
                case 2:
                    this.ThirdChoice();
                    break;
                case 3:
                    this.ForthChoice();
                    break;
                case 5:
                    this.ExitMiscMenu();
                    break;
            }
        }

        public void FirstChoice()
        {
            Gifting<string, object, string> gifting = new Gifting<string, object, string>();
            System.Console.Clear();
            gifting.GiFt();
            System.Console.Clear();
            this.RunMiscMenu();
        }

        public static void SecondChoice()
        {
            System.Console.Clear();
            PhotonHost<string, string, int, bool> photonHost = new PhotonHost<string, string, int, bool>();
            photonHost.GiveHost();
        }


        public void ThirdChoice()
        {
        }

        public void ForthChoice()
        {
            System.Console.Clear();
            System.Console.ReadKey(true);
            this.RunMiscMenu();
        }
        public void ExitMiscMenu()
        {
            ModMenu modMenu = new ModMenu();
            modMenu.Start();
        }
    }
}
