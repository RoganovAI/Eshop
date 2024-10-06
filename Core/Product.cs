namespace Core
{
    public class Products
    {
        public const string NAME = "Products";

        int Id;
        int Stock;
        int Price;

        public static string GetInfo()
        {
            return "Получить список товаров(количество вводить через пробел)";
                
        }
        public static void Execute(int quantity)
        {
            int limit = quantity;
            int maxQuontity = 3;
            string result = "";
            string[] arrProducts = GetList();

            if (quantity == 0 || quantity > arrProducts.Length)
            {
                limit = maxQuontity;
            }

            for (int i = 0; i < limit; i++)
            {
                result += $"{i + 1}.{arrProducts[i]}\n";
            }
            
            Console.WriteLine(result);
        }

        private static string[] GetList()
        {
            string[] list = [
                                "Штаны за 40 гривен",
                                "Рубаха гучи",
                                "Шапка obey",
                                "Кроссовки абибас",
                                "Спортивные штаны: три полоски"                                
                            ];
            return list;
        }
    }
}
