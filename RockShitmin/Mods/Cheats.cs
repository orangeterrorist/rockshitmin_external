using System;
using System.Threading;
using RecRoom.Tools.Weapons;

namespace Rock.Mods
{
    public class Cheats<T1, T2>
    {
        public void RapidFire(decimal rof)
        {
            Pistol pistol = new Pistol();
            Console.Title = "RapidFire: Only Arena Weapons work At The Moment";
            Console.WriteLine("What would you like your fire rate to be? Type 1x-4x depending on what type you would like: ");
            Cheats<bool, bool> cheats = new Cheats<bool, bool>();
            cheats.IsEnabled = true;
            string a = Console.ReadLine();
            bool flag = a == "1x" || a == "2x" || a == "3x" || a == "4x";
            if (flag)
            {
                Console.WriteLine("Please type what weapon prefab you're holding.");
                Thread.Sleep(4000);
                string a2 = Console.ReadLine();
                bool flag2 = a2 == "[Arena_Pistol]";
                if (flag2)
                {
                    Pistol pistol2 = new Pistol();
                }
                else
                {
                    bool flag3 = a2 == "[Arena_RailGun]";
                    if (!flag3)
                    {
                        bool flag4 = a2 == "[Arena_Shotgun]";
                        if (!flag4)
                        {
                            bool flag5 = a2 == "[Arena_AutomaticGun]";
                            if (!flag5)
                            {
                                Thread.Sleep(3500);
                                Console.WriteLine("");
                            }
                        }
                    }
                }
                Console.WriteLine("Atemmpting to give weapon rapidfire ");
            }
        }

        internal void RapidFire()
        {
            //Cheats<bool, bool>.RapidFire(4m);
            throw new NotImplementedException();
        }
        public T1 IsEnabled;
        public T2 IsDisabled;
    }
}
