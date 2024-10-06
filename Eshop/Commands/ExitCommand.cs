using System;
using System.Text;

namespace Eshop.Commands
{
    public class ExitCommand
    {
        public const string NAME = "Exit";

        public static string GetInfo()
        {
            return "Выйти из приложения";
        }

        public static void Execute()
        {
            Environment.Exit(0);
        }
    }
}
