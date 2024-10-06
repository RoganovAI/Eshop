using Core;
using System;
using System.Text;

namespace Eshop.Commands
{
    public class DisplayCommandsCommand
    {
        public const string NAME = "DisplayCommands";

        public static string GetInfo()
        {
            return "Вывести список команд";
        }

        public static void Execute()
        {
            string dashes = "";
            for (int i = 0; i < 10; i++)
            {
                dashes += "-";
            }

            Console.WriteLine(dashes);
            Console.WriteLine($"{NAME} - {GetInfo()}");
            Console.WriteLine($"{ExitCommand.NAME} - {ExitCommand.GetInfo()}");
            Console.WriteLine($"{ClearConsoleCommand.NAME} - {ClearConsoleCommand.GetInfo()}");
            Console.WriteLine($"{Products.NAME} - {Products.GetInfo()}");
            Console.WriteLine($"{Services.NAME} - {Services.GetInfo()}");
            Console.WriteLine(dashes);
        }
    }
}
