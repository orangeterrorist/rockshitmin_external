using Rock.Menus;
using System;
using System.Net;
using System.Threading;

namespace Rock.Mods
{
    internal class Gifting<T1, T2, T3> : Menu
    {
        public void GiFt()
        {
            Gifting<string, object, string> gifting = new Gifting<string, object, string>();
            Console.WriteLine("Please type the @ user you would like to gift");
            gifting.Username_Of_receiver = Console.ReadLine();
            Console.WriteLine("Now, type the GUID of the gift you would like to send!");
            gifting.Item_to_gift = Console.ReadLine();
            Thread.Sleep(1);
            Console.Clear();
            //Menu.Auth = "";
            Console.WriteLine("Please enter your full AUTH token (ig Bearer): ");
            string token = Console.ReadLine();
            Authorization authorization = new Authorization(token);
            HttpListenerContext context = this.listener.GetContext();
            HttpListenerRequest request = context.Request;
            HttpListenerResponse response = context.Response;
            string rawUrl = request.RawUrl;
            bool flag = rawUrl.EndsWith("/api/avatar/v2/gifts/create");
            if (flag)
            {
                string str = "Trying to gift: ";
                T1 username_Of_receiver = this.Username_Of_receiver;
                Console.WriteLine(str + ((username_Of_receiver != null) ? username_Of_receiver.ToString() : null));
                GiftManager giftManager = new GiftManager();
                GiftBoxSpawnPoint giftBoxSpawnPoint = new GiftBoxSpawnPoint();
            }
        }

        public T1 Username_Of_receiver;
        public T2 Item_to_gift;
        public T3 PhotonId;
        public string[] Skins;
    }
}
