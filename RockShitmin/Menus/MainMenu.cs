using System;
using System.Drawing;
using System.Net;
using System.Threading;
using Colorful;
using Rock.Menus;
using Rock.Extensions;

namespace Rock.Menus
{
    internal class MainMenu
    {
        public void Start()
        {
            this.RunMainMenu();
        }
        private void RunMainMenu()
        {
            Colorful.Console.Title = "neptuneq | ShitminCheat (Odyssey)";
            LoginMenu<string, string, bool> loginMenu = new LoginMenu<string, string, bool>();
            bool flag = !MainMenu.Has_Logged_In;
            if (flag)
            {
                loginMenu.LoginScreen1();
            }
            string prompt = "\r\n-==========================================================================================================-\r\n-                                                                                                          -\r\n-             ██████╗ ██████╗ ██╗   ██╗███████╗███████╗███████╗██╗   ██╗██╗    ██╗████████╗███████╗        -\r\n-            ██╔═══██╗██╔══██╗╚██╗ ██╔╝██╔════╝██╔════╝██╔════╝╚██╗ ██╔╝██║    ██║╚══██╔══╝██╔════╝        -\r\n-            ██║   ██║██║  ██║ ╚████╔╝ ███████╗███████╗█████╗   ╚████╔╝ ██║ █╗ ██║   ██║   █████╗          -\r\n-            ██║   ██║██║  ██║  ╚██╔╝  ╚════██║╚════██║██╔══╝    ╚██╔╝  ██║███╗██║   ██║   ██╔══╝          -\r\n-            ╚██████╔╝██████╔╝   ██║   ███████║███████║███████╗   ██║██╗╚███╔███╔╝   ██║   ██║             -\r\n-             ╚═════╝ ╚═════╝    ╚═╝   ╚══════╝╚══════╝╚══════╝   ╚═╝╚═╝ ╚══╝╚══╝    ╚═╝   ╚═╝             -\r\n-                                                                                                          -\r\n-==========================================================================================================-                                                                                   \r\nWelcome to ShitminCheat (Odyssey.wtf) a Client built for Modding/Hacking RecRoom in any kind of Rec Room verisons";
            string[] options = new string[]
            {
                "Rules/Rules",
                "Mods",
                "Check For Updates",
                "Credits",
                "Debug",
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
                    this.DebugConsole();
                    break;
                case 5:
                    this.ExitGame();
                    break;
            }
        }

        public void FirstChoice()
        {
            Colorful.Console.Title = "neptuneq | Rules";
            Colorful.Console.Clear();
            Colorful.Console.WriteLine("1: Please do not leak this client or stream it on anytype of platform the punishment will be horrible\r\n2: DO NOT CLAIM OR TAKE THE credit for making this. if anyone else  sends you this client from the non orignal user link then you must of been hacked or ratted please contact  for help StereoCat#0001\r\n3: DO NOT GIVE YOUR KEYS OR ACCOUNT OF This Client to anyone else or we will have to force delete your key\r\n4: Visit Credits if you wanna find out the master minds of who made this sick client.\r\n5: Enjoy!\r\n-================================================================================================================================================================================================================================-\r\nHelp\r\n1:Commands that are now are  \r\n>Bypass.rar \r\n>DeveloperState On \r\n>DeveloperState Off \r\n>DiscordRPC.dll On \r\n>Discord.RPC.dll Off \r\n>rec.wtfserver\r\n>wrenchProtoype\r\n>genesis.dll /downloadsrc\r\n>OpenRec /downloadsrc\r\nNote: if you are getting errors with this client please contact Stereo#0001 or rockpikmin888#8888", Color.HotPink);
            Colorful.Console.ReadKey(true);
            Colorful.Console.Clear();
            this.RunMainMenu();
        }

        public void SecondChoice()
        {
            Colorful.Console.ForegroundColor = Color.DeepPink;
            Colorful.Console.Title = "neptuneq | Going to Mods Screen...";
            Colorful.Console.Clear();
            Colorful.Console.WriteLine("You are now going to the mod menu screen");
            Thread.Sleep(1800);
            Colorful.Console.Clear();
            ModMenu modMenu = new ModMenu();
            modMenu.Start();
        }

        public void ThirdChoice()
        {
            Colorful.Console.Title = "Checking for updates...";
            Colorful.Console.CursorVisible = false;
            Colorful.Console.SetCursorPosition(1, 1);
            Colorful.Console.Clear();
            for (int i = 0; i < 100; i++)
            {
                Colorful.Console.SetCursorPosition(0, 0);
                Colorful.Console.Write("");
                for (int j = 0; j < i; j++)
                {
                    string value = "■";
                    Colorful.Console.Write(value);
                }
                Colorful.Console.Write(" " + (i + 1).ToString() + " / 100");
                Colorful.Console.SetCursorPosition(0, 0);
                System.Console.ForegroundColor = ConsoleColor.Green;
                Thread.Sleep(25);
            }
            Colorful.Console.SetCursorPosition(0, 0);
            Colorful.Console.Clear();
            Colorful.Console.WriteLine("Error not out yet", Color.Red);
            Thread.Sleep(1500);
            Colorful.Console.ResetColor();
            Colorful.Console.Clear();
            this.RunMainMenu();
        }

        public void ForthChoice()
        {
            Colorful.Console.Title = "neptuneq | Credits";
            Colorful.Console.Clear();
            Colorful.Console.WriteLine("\r\n0: [neptune#1995] gaming\r\n 1: [StereoCat#0001] Made The Client Menu/Owner Of The Project.\r\n2: [Pirates#0001] Quest Modder, Money Management and Domain Buyer (The only reason why we are doing this again...) \r\n3: [Nexus#0003] God Father of this Project.\r\n4: [Miles TWA#0843] Lookout and Tester (I did all of the Work and for the gays I didn't ruin anything dadddy fuckk me, I don't want a black son lynching my fave).\r\n5: [tui2#9602/Gribben] Quest Modder/Helper Website Graphic Designer.\r\n6: [fchb1239#5358] Server hookup and idea creator of the domain length method. \r\n7: [Grandkid#4357] He's just grandkid.\r\n8: [rockpikmin888#8888] Major Code Helper, Carried the project with Gifting, Logins, Rapidfire, MakerPen, and many more.\r\n9: [Icy#1069] Overdose to help and not go to school.\r\n10:[Bruto#8468/BlueBalls] Support Team (Tester)", Color.Orange);
            Colorful.Console.WriteLine("After you are done reading you may click enter to return to the main menu.");
            Colorful.Console.ReadKey(true);
            this.RunMainMenu();
        }

        public void DebugConsole()
        {
            Colorful.Console.Title = "neptuneq | Debug ";
            Colorful.Console.Clear();
            WebClient webClient = new WebClient();
            Colorful.Console.WriteLine("Enter a command: type !help for a list of commands ", Color.MistyRose);
            string a = Colorful.Console.ReadLine();
            bool flag = a == ">EACBypass";
            if (flag)
            {
                WebClient webClient2 = new WebClient();
                string address = webClient2.DownloadString("https://pastebin.com/raw/mUdxLz1H");
                webClient2.DownloadFile(address, "EACBypass.rar");
                Colorful.Console.WriteLine("Bypass downloaded! It's recommended you make an exception for it.");
                Thread.Sleep(5000);
                Colorful.Console.Clear();
                this.DebugConsole();
            }
            else
            {
                bool flag2 = a == ">OpenRec /src";
                if (flag2)
                {
                    Thread.Sleep(200);
                    WebClient webClient3 = new WebClient();
                    Colorful.Console.WriteLine("penis.fbx downloaded");
                    Colorful.Console.Clear();
                    this.DebugConsole();
                }
                else
                {
                    bool flag3 = a == ">Harmonica /src";
                    if (flag3)
                    {
                        WebClient webClient4 = new WebClient();
                        webClient4.DownloadFile("https://github.com/recroom2016/OpenRec.git", "OpenRec.zip");
                        Colorful.Console.WriteLine("Finished");
                        Colorful.Console.ReadKey(true);
                    }
                    else
                    {
                        bool flag4 = a == ">Harmonica /src";
                        if (flag4)
                        {
                            Colorful.Console.WriteLine("In Progress: ");
                            Thread.Sleep(4000);
                            Colorful.Console.Clear();
                            this.DebugConsole();
                        }
                        else
                        {
                            bool flag5 = a == ">genesis.dll /src";
                            if (!flag5)
                            {
                                bool flag6 = a == ">rockpikmin888 /client";
                                if (flag6)
                                {
                                    Colorful.Console.Clear();
                                    Menu menu = new Menu();
                                    menu.MenuRock();
                                }
                                else
                                {
                                    bool flag7 = a == ">login_test";
                                    if (flag7)
                                    {
                                        new LoginMenu<string, string, bool>
                                        {
                                            Already_Has_Account = true
                                        }.LoginScreen1();
                                    }
                                    else
                                    {
                                        bool flag8 = a == ">PhotonHost";
                                        if (!flag8)
                                        {
                                            bool flag9 = a == ">GoBack";
                                            if (flag9)
                                            {
                                                Colorful.Console.ForegroundColor = Color.Red;
                                                Colorful.Console.WriteLine("Going back");
                                                Thread.Sleep(4000);
                                                Colorful.Console.ResetColor();
                                                this.RunMainMenu();
                                            }
                                            else
                                            {
                                                bool flag10 = a == "!help";
                                                if (flag10)
                                                {
                                                    string value = webClient.DownloadString("https://pastebin.com/raw/5evuYvc7");
                                                    Colorful.Console.WriteLine(value);
                                                    Colorful.Console.ReadLine();
                                                    Colorful.Console.Clear();
                                                    this.DebugConsole();
                                                }
                                                else
                                                {
                                                    bool flag11 = a == ">MiscMenu /test";
                                                    if (!flag11)
                                                    {
                                                        Colorful.Console.WriteLine("Error Incorrect Command, please type !help for a list of commands.");
                                                        Colorful.Console.ReadLine();
                                                        Colorful.Console.Clear();
                                                        this.DebugConsole();
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        public void ExitGame()
        {
            Environment.Exit(0);
        }
        public static bool Has_Logged_In;
    }
}
