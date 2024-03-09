using System;
using System.Drawing;
using System.Net;
using System.Threading;
using Colorful;

namespace Rock.Menus
{
    // Token: 0x0200000C RID: 12
    public class LoginMenu<T1, T2, T3>
    {
        public T1 UserName_PassWord { get; set; }
        public T2 Password { get; set; }
        public T3 Already_Has_Account { get; set; }

        public void Start()
        {
            this.LoginScreen1();
        }

        public void LoginScreen1()
        {
            System.Console.Title = "neptuneq | ShitminCheat (Login)";
            try
            {
                LoginMenu<string, string, bool> loginMenu = new LoginMenu<string, string, bool>();
                System.Console.Clear();
                Colorful.Console.ForegroundColor = Color.HotPink;
                WebClient webClient = new WebClient();
                string value = "\r\n██╗      ██████╗  ██████╗ ██╗███╗   ██╗\r\n██║     ██╔═══██╗██╔════╝ ██║████╗  ██║\r\n██║     ██║   ██║██║  ███╗██║██╔██╗ ██║\r\n██║     ██║   ██║██║   ██║██║██║╚██╗██║\r\n███████╗╚██████╔╝╚██████╔╝██║██║ ╚████║\r\n╚══════╝ ╚═════╝  ╚═════╝ ╚═╝╚═╝  ╚═══╝\r\n                                       \r\n                                                                            \r\nWelcome to ShitminCheat, a Client built for Cheating in RecRoom in any kind of Rec Room verisons. Please Login!";
                System.Console.WriteLine(value);
                System.Console.WriteLine("Please enter le password, Example: neptune", Color.Red);
                //Thread.Sleep(1);
                System.Console.Write("Username and Password: ");
                loginMenu.UserName_PassWord = System.Console.ReadLine();
                string[] array = new string[10];
                array[0] = "neptune";
                array[1] = "hi";
                array[2] = "podo";
                bool flag = loginMenu.UserName_PassWord == array[0];
                if (flag)
                {
                    Thread.Sleep(5000);
                    System.Console.WriteLine("Logged in!");
                    System.Console.WriteLine("Welcome: Neptune1995 ", Color.Red);
                    Thread.Sleep(3500);
                    System.Console.Clear();
                    System.Console.WriteLine("Now taking you into the MainMenu!");
                    System.Console.Title = LoginMenu<T1, T2, T3>.TITILE + " Going to MainMenu...";
                    MainMenu.Has_Logged_In = true;
                    Thread.Sleep(5000);
                    System.Console.Clear();
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Start();
                }
                else
                {
                    bool flag2 = loginMenu.UserName_PassWord == array[1];
                    if (flag2)
                    {
                        Thread.Sleep(5000);
                        System.Console.WriteLine("Logged in!");
                        System.Console.WriteLine("Welcome: hi ", Color.Goldenrod);
                        Thread.Sleep(3500);
                        System.Console.Clear();
                        System.Console.WriteLine("Now taking you into the MainMenu!");
                        System.Console.Title = LoginMenu<T1, T2, T3>.TITILE + " Going to MainMenu...";
                        MainMenu.Has_Logged_In = true;
                        Thread.Sleep(5000);
                        System.Console.Clear();
                        MainMenu mainMenu2 = new MainMenu();
                        mainMenu2.Start();
                    }
                    else
                    {
                        bool flag3 = loginMenu.UserName_PassWord == array[2];
                        if (flag3)
                        {
                            Thread.Sleep(5000);
                            System.Console.WriteLine("Logged in!");
                            System.Console.WriteLine("Welcome: podo ", Color.Crimson);
                            Thread.Sleep(3500);
                            System.Console.Clear();
                            System.Console.WriteLine("Now taking you into the MainMenu!");
                            System.Console.Title = LoginMenu<T1, T2, T3>.TITILE + " Going to MainMenu...";
                            MainMenu.Has_Logged_In = true;
                            Thread.Sleep(5000);
                            System.Console.Clear();
                            MainMenu mainMenu3 = new MainMenu();
                            mainMenu3.Start();
                        }
                        else
                        {
                            Colorful.Console.ForegroundColor = Color.HotPink;
                            System.Console.WriteLine("Failed to login... ");
                            Thread.Sleep(1300);
                            System.Console.WriteLine("Going back to login menu...");
                            System.Console.Title = LoginMenu<T1, T2, T3>.TITILE + " (Going back to login menu)";
                            Thread.Sleep(1500);
                            System.Console.Clear();
                            this.LoginScreen1();
                        }
                    }
                }
            }
            catch
            {
                System.Console.WriteLine("An error has occured: You might have typed your account information wrong, or some other error has occured");
                Thread.Sleep(4000);
                System.Console.WriteLine("Trying again");
                Thread.Sleep(1000);
                System.Console.Clear();
                this.LoginScreen1();
                System.Console.Clear();
            }
        }
        public static string TITILE = "neptuneq | ShitminCheat";
    }
}
