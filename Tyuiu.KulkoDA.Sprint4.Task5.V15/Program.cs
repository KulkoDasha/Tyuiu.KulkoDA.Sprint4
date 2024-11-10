using Tyuiu.KulkoDA.Sprint4.Task5.V15.Lib;
namespace Tyuiu.KulkoDA.Sprint4.Task5.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.Title = "Спринт #4 | Выполнила: Кулько Д. А. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнила: Кулько Дарья Андреевна | ИИПб-24-2                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями от -6 до 4.Найти сумму положительных элементов.   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите количество строк в массиве: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в массиве: ");
            int cols = Convert.ToInt32(Console.ReadLine());
            int[,] mt = new int[row, cols];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    
                    mt[i, j] = rnd.Next(-6,4);
                }

            }
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{mt[i, j]}\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(mt) );
            Console.ReadLine();
        }
    }
}
