using Tyuiu.KulkoDA.Sprint4.Task7.V3.Lib;
namespace Tyuiu.KulkoDA.Sprint4.Task7.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int m = 2;
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Кулько Д. А. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнила: Кулько Дарья Андреевна | ИИПб-24-2                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"27182818\". Преобразуйте ее         *");
            Console.WriteLine("* в матрицу 4 на 2 и подсчитайте количество нечетных чисел в матрице.     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");
            int index = 0;
            int[,] mt = new int[n,m];
            string str = "27182818";
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]}\t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(n, m, str));
            Console.ReadLine();
        }
    }
}
