using System;//подключаем пространство имен System
using System.Globalization;
double a = 46;//объявление количества строк
double b = 11;//объявления количества комментариев
double F = a / b;//оцениваем уровень комментированности 
Console.WriteLine(F);
//подключаем пространство имен
namespace ConsoleApp1
{
    internal class Program//подключение класса
    {
        private static void Main()
        {

            //Способ 1: Parse 
            Int32 val1 = Int32.Parse("100");//простое преобразование
            Int32 val2 = Int32.Parse("(200)", NumberStyles.AllowParentheses);//перегрузка с указанием стиля
            int val3 = int.Parse("30,000", NumberStyles.AllowThousands, new CultureInfo("en-au"));//перегрузка с указанием стиля и культуры
            Console.WriteLine($"{val1} {val2} {val3}");

            //Обработка исключений при преобразованиях 1 и 2:
            string str1 = "100f";
            try
            {
                val1 = Int32.Parse(str1);
                Console.WriteLine(val1);
            }
            catch (Exception e)
            {
                Console.WriteLine("Неверный формат Parse: " + str1);
            }
            try
            {
                val1 = Convert.ToInt32(str1);
                Console.WriteLine(val1);
            }
            catch (Exception e)
            {
                Console.WriteLine("Неверный формат ToInt32: " + str1);
            }

            Console.ReadKey();
        }

    }
}