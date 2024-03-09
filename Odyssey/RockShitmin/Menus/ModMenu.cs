using Rock.Menus;
using System;
using System.Diagnostics;
using Rock.Extensions;
using Rock.Mods;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes.Gcm;

namespace Rock.Menus
{
    // Token: 0x02000010 RID: 16
    internal class ModMenu
    {
        // Token: 0x0600004A RID: 74 RVA: 0x00003A70 File Offset: 0x00001C70
        public void Start()
        {
            this.RunModMenu();
        }

        // Token: 0x0600004B RID: 75 RVA: 0x00003A7C File Offset: 0x00001C7C
        private void RunModMenu()
        {
            Console.Title ="| ShitminCheat (Mods)";
            string prompt = "\r\n███╗   ███╗ ██████╗ ██████╗ ███████╗\r\n████╗ ████║██╔═══██╗██╔══██╗██╔════╝\r\n██╔████╔██║██║   ██║██║  ██║███████╗\r\n██║╚██╔╝██║██║   ██║██║  ██║╚════██║\r\n██║ ╚═╝ ██║╚██████╔╝██████╔╝███████║\r\n╚═╝     ╚═╝ ╚═════╝ ╚═════╝ ╚══════╝\r\n                                    \r\n  \r\n                                                                                      \r\nWelcome to ShitminCheat (Odyssey.wtf) a Client built for Modding/Hacking RecRoom in any kind of Rec Room versions.";
            string[] options = new string[]
            {
                "Weapons",
                "Nothing",
                "Rapid Fire",
                "Misc Menu",
                "Help",
                "Exit"
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
            Process[] processesByName = Process.GetProcessesByName("RecRoom");
            bool flag = processesByName.Length == 0;
            if (flag)
            {
                Console.WriteLine("RecRoom is running");
            }
            else
            {
                Console.WriteLine("RecRoom is not running");
            }
            Console.Clear();
            string[] array = new string[]
            {
                "Arena_Pistol",
                "Arena_Shotgun",
                "ArenaRocketLauncher",
                "Arena_BeamGun",
                "PaintballGun",
                "PaintballShotGun",
                "Paintball_Assualt"
            };
            Console.Write("Enter a command:");
            string text = Console.ReadLine();
            string a = text;
            string str = ">sizemodifer";
            string[] array2 = array;
            bool flag2 = a == str + ((array2 != null) ? array2.ToString() : null);
            if (flag2)
            {
                Console.WriteLine("Size Has been changed");
                Console.ReadKey(true);
                Console.Clear();
                this.RunModMenu();
            }
            else
            {
                Console.WriteLine("Failed Reverting Back to Mod Menu...");
                Console.ReadKey(true);
                Console.Clear();
                this.RunModMenu();
            }
        }

        public void SecondChoice()
        {
            Console.Clear();
            Console.WriteLine("Coming Soon");
            Console.ReadKey();
            Console.Clear();
            this.RunModMenu();
        }

        public void ThirdChoice()
        {
            Console.Clear();
            Console.WriteLine("Taking you into the Rapid Fire");
            Cheats<bool, bool> cheats = new Cheats<bool, bool>();
            cheats.RapidFire();
        }

        public void ForthChoice()
        {
            Console.Clear();
            Console.WriteLine("Taking you into the Misc Screen");
            MiscMenu miscMenu = new MiscMenu();
            miscMenu.Start();
        }

        public void FifthChoice()
        {
            Console.Clear();
            Console.WriteLine("List of commands:\r\n1:>weaponsize{0}\r\n2:>playerspeed{0}\r\nNote: More to come soon...");
            Console.ReadKey();
            Console.Clear();
            this.RunModMenu();
        }

        public void ExitModMenu()
        {
            Console.Clear();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Start();
        }
    }
}
