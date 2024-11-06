using Tyuiu.KulkoDA.Sprint4.Task2.V5.Lib;
namespace Tyuiu.KulkoDA.Sprint4.Task2.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Кулько Д. А. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                   *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнила: Кулько Дарья Андреевна | ИИПб-24-2                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов из случайных чисел  *");
            Console.WriteLine("* подсчитать произведение четных элементов массива.   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            int len;
            Random rand = new Random();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите количество элементов массива: *");
            len = Convert.ToInt32(Console.ReadLine());
            int[] m = new int[len];
            for (int i = 0; i < len; i++)
            {

                m[i] = rand.Next(3, 9);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(m));
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
