using System;

namespace SimpleMenu
{
    class Login
    {
        static void Main(string[] args)
        {
            Console.Title = "Login";

            MainMenu.writeLogo();
            Console.WriteLine("Welcome Back!");
            Console.ReadKey(true);
            MainMenu.Menu();
        }
    }
}