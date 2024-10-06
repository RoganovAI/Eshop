using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Commands
{
    public class ClearConsoleCommand
    {
        public const string NAME = "cls";

        public static string GetInfo()
        {
            return "Очистить консоль";
        }

        public static void Execute()
        {
            Console.Clear();
        }
    }
}
