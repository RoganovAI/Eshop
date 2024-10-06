using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Services
    {
        public const string NAME = "Services";

        int Id;
        int Price;

        public static string GetInfo()
        {
            return "Получить список услуг(количество вводить через пробел)";
        }
        public static void Execute(int quantity)
        {
            int limit = quantity;
            int maxQuontity = 3;
            string result = "";
            string[] arrServices = GetList();

            if (quantity == 0 || quantity > arrServices.Length)
            {
                limit = maxQuontity;
            }

            for (int i = 0; i < limit; i++)
            {
                result += $"{i + 1}.{arrServices[i]}\n";
            }

            Console.WriteLine(result);
        }

        private static string[] GetList()
        {
            string[] list = [
                                "Наклеить пленку на телефон",
                                "Установить защитное стекло",
                                "Замена экрана",
                                "Восстановление данных с устройства",
                                "Смена мелодии звонка"
                            ];
            return list;
        }
    }
}
