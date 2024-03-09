using System;

namespace Rock.Extensions
{
    public class MenuController
    {
        public MenuController(string prompt, string[] options)
        {
            this.Prompt = prompt;
            this.Options = options;
            this.Selectedindex = 0;
        }

        public void DisplayOptions()
        {
            Console.WriteLine(this.Prompt);
            for (int i = 0; i < this.Options.Length; i++)
            {
                string text = this.Options[i];
                bool flag = i == this.Selectedindex;
                if (flag)
                {
                    this.prefix = ">";
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    this.prefix = " ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Magenta;
                }
                Console.WriteLine(string.Concat(new string[]
                {
                    " ",
                    this.prefix,
                    " ",
                    text,
                    " "
                }));
            }
            Console.ResetColor();
        }

        public int Run()
        {
            ConsoleKey key;
            do
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(0, 0);
                this.DisplayOptions();
                key = Console.ReadKey(true).Key;
                bool flag = key == ConsoleKey.UpArrow;
                if (flag)
                {
                    this.Selectedindex--;
                    bool flag2 = this.Selectedindex == -1;
                    if (flag2)
                    {
                        this.Selectedindex = this.Options.Length - 1;
                    }
                }
                else
                {
                    bool flag3 = key == ConsoleKey.DownArrow;
                    if (flag3)
                    {
                        this.Selectedindex++;
                        bool flag4 = this.Selectedindex == this.Options.Length;
                        if (flag4)
                        {
                            this.Selectedindex = 0;
                        }
                    }
                }
            }
            while (key != ConsoleKey.Enter);
            return this.Selectedindex;
        }

        private int Selectedindex;
        private string[] Options;
        private string Prompt;
        private string prefix;
    }
}
