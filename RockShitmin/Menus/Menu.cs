using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using Newtonsoft.Json;
using Rock.Mods;

namespace Rock.Menus
{
    internal class Menu
    {
        public static HttpClient ApiHelper { get; set; }
        public void MenuRock()
        {
            Console.Title = Menu.Creator;
            Console.ForegroundColor = ConsoleColor.Red;
            bool flag = !Menu.Isusable;
            if (flag)
            {
                Console.WriteLine("You're not allowed to use this software");
                Console.WriteLine("Closing");
                Thread.Sleep(4000);
                Environment.Exit(1);
                Console.ReadKey();
            }
            Console.WriteLine("Hello");
            Thread.Sleep(800);
            Console.WriteLine("Finding RecRoom");
            Process[] processesByName = Process.GetProcessesByName("RecRoom");
            bool flag2 = processesByName.Length == 0;
            if (flag2)
            {
                Console.WriteLine("RecRoom.exe is not running");
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("Please try again");
                Thread.Sleep(2000);
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("RecRoom found");
                Thread.Sleep(800);
                Console.Clear();
                Console.WriteLine("Please type your RecRoom @ username please include a / at the end ");
                Menu.Username = Console.ReadLine();
                Console.WriteLine("Please type your RecRoom password");
                Menu.Password = Console.ReadLine();
                WebClient webClient = new WebClient();
                try
                {
                    Menu.Auth = webClient.DownloadString("https://npapi.neptuneq.repl.co" + Menu.Username + Menu.Password);
                    Console.Clear();
                    Console.WriteLine("AUTH: " + Menu.Auth);
                    Menu.START();
                }
                catch
                {
                    Console.WriteLine("An API Auth error has occured: You might have typed your user name, or your password in wrong.");
                    Thread.Sleep(4000);
                }
                Thread.Sleep(7000);
                Console.Clear();
                Console.WriteLine("Please type what option you would like to do");
                Console.WriteLine("Clothing:");
                Console.WriteLine("RapidFire:");
                Console.WriteLine("PhotonHost:");
                Console.WriteLine("MakerPen:");
                Console.WriteLine("Gifting:");
                try
                {
                    string a = Console.ReadLine();
                    bool flag3 = a == "PhotonHost";
                    if (flag3)
                    {
                        Console.Clear();
                        Console.WriteLine("Making User Host Of Room Instance");
                    }
                    else
                    {
                        bool flag4 = a == "RapidFire";
                        if (flag4)
                        {
                            Console.Clear();
                            Console.WriteLine("Not Finsihed");
                            Thread.Sleep(6000);
                            Environment.Exit(1);
                        }
                        else
                        {
                            bool flag5 = a == "Clothing";
                            if (!flag5)
                            {
                                bool flag6 = a == "Gifting";
                                if (flag6)
                                {
                                    Gifting<string, object, string> gifting = new Gifting<string, object, string>();
                                    Console.Clear();
                                    gifting.GiFt();
                                }
                                else
                                {
                                    bool flag7 = a == "MakerPen";
                                    if (flag7)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Not Finsihed");
                                        Thread.Sleep(6000);
                                        Environment.Exit(1);
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception value)
                {
                    Console.WriteLine(value);
                }
            }
        }

        private void HTTP()
        {
            Menu.ApiHelper = new HttpClient();
            Menu.ApiHelper.DefaultRequestHeaders.Accept.Clear();
            Menu.ApiHelper.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpListenerContext context = this.listener.GetContext();
            HttpListenerRequest request = context.Request;
            HttpListenerResponse response = context.Response;
            string rawUrl = request.RawUrl;
            bool flag = rawUrl.StartsWith("/api/equipment/v2/getUnlocked");
            if (flag)
            {
                Console.WriteLine("Changing items");
            }
            else
            {
                Console.WriteLine("Api not called");
            }
        }

        public static void START()
        {
        }

    public HttpListener listener = new HttpListener();
    public static readonly string Creator = " Made by: Rockpikmin888#8888 & neptune#1995";
    public static readonly bool Isusable = false;
    public static string Auth;
    public static string Username;
    public static string Password;
}
}