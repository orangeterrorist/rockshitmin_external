using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using Colorful;
using Photon.Pun;
using RecRoom.Systems.PlayerRoles;

namespace Rock.Mods
{
    public class PhotonHost<T1, T2, T3, T4>
    {
        public string GiveHost()
        {
            PhotonHost<string, string, int, bool> photonHost = new PhotonHost<string, string, int, bool>();
            Colorful.Console.ForegroundColor = Color.MistyRose;
            Process[] processesByName = Process.GetProcessesByName("RecRoom");
            bool flag = processesByName.Length == 0;
            if (flag)
            {
                Colorful.Console.ForegroundColor = Color.IndianRed;
                Colorful.Console.WriteLine("RecRoom is running: ");
                Colorful.Console.ForegroundColor = Color.GreenYellow;
                Colorful.Console.WriteLine(" Giving Player Host ");
                //PhotonHost<T1, T2, T3, T4>.ColorfulAnimation();
                PUNNetworkManager punnetworkManager = new PUNNetworkManager();
                punnetworkManager.GetInstanceID();
                punnetworkManager.WasSpawnedForPlayer(1);
                punnetworkManager.MasterSwitchToBestCandidatePlayer();
                PhotonView photonView = new PhotonView();
                RoomRole roomRole = new RoomRole();
                PhotonTransformView photonTransformView = new PhotonTransformView();
                photonTransformView.Update();
                Colorful.Console.ForegroundColor = Color.LightPink;
                Colorful.Console.WriteLine(" /$$   /$$                                     /$$                                                         /$$$$$$$  /$$                   /$$                         /$$   /$$                       /$$    \r\n| $$  | $$                                    |__/                                                        | $$__  $$| $$                  | $$                        | $$  | $$                      | $$    \r\n| $$  | $$  /$$$$$$$  /$$$$$$   /$$$$$$        /$$  /$$$$$$$       /$$$$$$$   /$$$$$$  /$$  /$$  /$$      | $$  \\ $$| $$$$$$$   /$$$$$$  /$$$$$$    /$$$$$$  /$$$$$$$ | $$  | $$  /$$$$$$   /$$$$$$$ /$$$$$$  \r\n| $$  | $$ /$$_____/ /$$__  $$ /$$__  $$      | $$ /$$_____/      | $$__  $$ /$$__  $$| $$ | $$ | $$      | $$$$$$$/| $$__  $$ /$$__  $$|_  $$_/   /$$__  $$| $$__  $$| $$$$$$$$ /$$__  $$ /$$_____/|_  $$_/  \r\n| $$  | $$|  $$$$$$ | $$$$$$$$| $$  \\__/      | $$|  $$$$$$       | $$  \\ $$| $$  \\ $$| $$ | $$ | $$      | $$____/ | $$  \\ $$| $$  \\ $$  | $$    | $$  \\ $$| $$  \\ $$| $$__  $$| $$  \\ $$|  $$$$$$   | $$    \r\n| $$  | $$ \\____  $$| $$_____/| $$            | $$ \\____  $$      | $$  | $$| $$  | $$| $$ | $$ | $$      | $$      | $$  | $$| $$  | $$  | $$ /$$| $$  | $$| $$  | $$| $$  | $$| $$  | $$ \\____  $$  | $$ /$$\r\n|  $$$$$$/ /$$$$$$$/|  $$$$$$$| $$            | $$ /$$$$$$$/      | $$  | $$|  $$$$$$/|  $$$$$/$$$$/      | $$      | $$  | $$|  $$$$$$/  |  $$$$/|  $$$$$$/| $$  | $$| $$  | $$|  $$$$$$/ /$$$$$$$/  |  $$$$/\r\n \\______/ |_______/  \\_______/|__/            |__/|_______/       |__/  |__/ \\______/  \\_____/\\___/       |__/      |__/  |__/ \\______/    \\___/   \\______/ |__/  |__/|__/  |__/ \\______/ |_______/    \\___/  \r\n                                                                                                                                                                                                              \r\n                                                                                                                                                                                                              \r\n                                                                                                                                                                                                              ");
            }
            Colorful.Console.WriteLine("Please type your RecRoom @ name ");
            string photonHostUserName = Colorful.Console.ReadLine();
            photonHost.PhotonHostUserName = photonHostUserName;
            return photonHost.PhotonHostUserName;
        }

        private static void ColorfulAnimation()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    Colorful.Console.Clear();
                    Colorful.Console.Write("       . . . . o o o o o o", Color.LightGray);
                    for (int k = 0; k < j / 2; k++)
                    {
                        Colorful.Console.Write(" o", Color.LightGray);
                    }
                    Colorful.Console.WriteLine();
                    string str = "".PadLeft(j);
                    Colorful.Console.WriteLine(str + "                _____      o", Color.LightGray);
                    Colorful.Console.WriteLine(str + "       ____====  ]OO|_n_n__][.", Color.DeepSkyBlue);
                    Colorful.Console.WriteLine(str + "      [________]_|__|________)< ", Color.DeepSkyBlue);
                    Colorful.Console.WriteLine(str + "       oo    oo  'oo OOOO-| oo\\_", Color.Blue);
                    Colorful.Console.WriteLine("   +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+", Color.Silver);
                    Thread.Sleep(200);
                }
            }
        }

        public T1 PhotonID;
        public T2 PhotonHostUserName;
        public T3 PhotonRoomInstance;
        public T4 IsHost;
        public bool CanUseMakerPen = true;
    }
}
