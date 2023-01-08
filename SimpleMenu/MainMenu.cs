using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Colorful;
using Console = Colorful.Console;
using System.Threading;

namespace SimpleMenu
{
	class MainMenu
	{

		public static void Menu()
		{
			for(; ; )
			{
                Console.Clear();
                writeLogo();
                Say("1", "A");
                Say("2", "B");
                Say("3", "C");
                Say("4", "EXIT");
                string option = Console.ReadLine();
                if (option == "1")
                {
                    //option A
                }
                else if (option == "2")
                {
                    //option B
                }
                else if (option == "3")
                {
                    //option C
                }
                else if (option == "4")
                {
                    //Exit the APP
                }
                else
                {
                    Console.WriteLine("ERROR! Please choose again!");
                    Thread.Sleep(1000);
                }
            }

		}

		public static void Say(string prefix, string message)
		{
            Console.Write("[");
            Console.Write(prefix, Color.BlueViolet);
            Console.WriteLine("] " + message);
        }

		public static void writeLogo()
		{
			string logo = @" __ _                 _                                
/ _(_)_ __ ___  _ __ | | ___    /\/\   ___ _ __  _   _ 
\ \| | '_ ` _ \| '_ \| |/ _ \  /    \ / _ \ '_ \| | | |
_\ \ | | | | | | |_) | |  __/ / /\/\ \  __/ | | | |_| |
\__/_|_| |_| |_| .__/|_|\___| \/    \/\___|_| |_|\__,_|
               |_|
";

			Console.WriteLine(logo, Color.Blue);

        }
	}
}

