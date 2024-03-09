using System;
using Rock.Extensions;
using Rock.Mods;

namespace Rock.Menus
{
    internal class WeaponsMenu
    {
        public void Start()
        {
            this.RunWeaponMenu();
        }

        private void RunWeaponMenu()
        {
            Console.Title = "Weapons";
            string prompt = "\r\n███╗   ███╗ ██████╗ ██████╗ ███████╗\r\n████╗ ████║██╔═══██╗██╔══██╗██╔════╝\r\n██╔████╔██║██║   ██║██║  ██║███████╗\r\n██║╚██╔╝██║██║   ██║██║  ██║╚════██║\r\n██║ ╚═╝ ██║╚██████╔╝██████╔╝███████║\r\n╚═╝     ╚═╝ ╚═════╝ ╚═════╝ ╚══════╝\r\n                                    \r\n  \r\n                                                                                      \r\nWelcome to ShitminCheat (Odyssey.wtf) a Client built for Modding/Hacking RecRoom in any kind of Rec Room verisons";
            string[] options = new string[]
            {
                "Rapidfire",
                "Bullet Size Modifer",
                "Bullet Shape",
                "EX_Modifer",
                "EG_Modifer",
                "Go back to Mod Menu"
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
                    this.SecondChoice();
                    break;
                case 2:
                    this.ThirdChoice();
                    break;
                case 3:
                    this.ForthChoice();
                    break;
                case 4:
                    this.FifthChoice();
                    break;
                case 5:
                    this.ExitModMenu();
                    break;
            }
        }

        public void FirstChoice()
        {
            Cheats<bool, bool> cheats = new Cheats<bool, bool>();
            cheats.RapidFire();
        }

        public void SecondChoice()
        {
            Console.Clear();
            Console.WriteLine("Coming Soon");
            Console.ReadKey();
            Console.Clear();
        }

        public void ThirdChoice()
        {
            Console.Clear();
            Console.WriteLine("Coming Soon");
            Console.ReadKey();
            Console.Clear();
        }

        public void ForthChoice()
        {
            Console.Clear();
            Console.WriteLine("Coming Soon");
            Console.ReadKey();
            Console.Clear();
        }

        public void FifthChoice()
        {
            Console.Clear();
            Console.WriteLine("Coming Soon");
            Console.ReadKey();
            Console.Clear();
        }

        public void ExitModMenu()
        {
            Console.Clear();
            Console.WriteLine("Coming Soon");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
