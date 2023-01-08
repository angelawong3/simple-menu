using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleMenu
{
	class MainMenu
	{
		public static void writeLogo()
		{
			string logo = @" __ _                 _                                
/ _(_)_ __ ___  _ __ | | ___    /\/\   ___ _ __  _   _ 
\ \| | '_ ` _ \| '_ \| |/ _ \  /    \ / _ \ '_ \| | | |
_\ \ | | | | | | |_) | |  __/ / /\/\ \  __/ | | | |_| |
\__/_|_| |_| |_| .__/|_|\___| \/    \/\___|_| |_|\__,_|
               |_|
";

			Console.WriteLine(logo);

        }
	}
}

