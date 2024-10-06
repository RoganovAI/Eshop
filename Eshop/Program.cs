using Core;
using Eshop.Commands;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
    
            Console.WriteLine("Введите команду");
            var command = Console.ReadLine();

            Execute(command);
        }
    }

    private static void Execute(string? command)
    {
        string? command_ = command;
        int quantity = 0;

        if (command != null)
        {
            command_ = command_.Trim();
            string[] words = command_.Split(" ");

            if (words.Length == 2)
            {
                command_ = words[0];

                bool isNumber = int.TryParse(words[1], out quantity);

                if (!isNumber)
                {
                    Console.WriteLine("Количество укaзано некорректно");
                    return;
                }
            }
        }

        switch(command_) {
            case DisplayCommandsCommand.NAME:
                DisplayCommandsCommand.Execute();
                break;
            case ExitCommand.NAME:
                ExitCommand.Execute();
                break;
            case ClearConsoleCommand.NAME:
                ClearConsoleCommand.Execute();
                break;
            case Products.NAME:
                Products.Execute(quantity);
                break;
            case Services.NAME:
                Services.Execute(quantity);
                break;
            default:
                Console.WriteLine("Неизвестная команда");
                break;    
        } 
    }
}