using Tyuiu.KulkoDA.Sprint4.Task1.V29.Lib;
namespace Tyuiu.KulkoDA.Sprint4.Task1.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Кулько Д. А. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                           *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнила: Кулько Дарья Андреевна | ИИПб-24-2                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры, подсчитать сумму нечетных элементов массива.   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            int len;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите количество элементов массива: *");
            len = Convert.ToInt32(Console.ReadLine());
            int[] m = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Введите значение " + i + " элемента массива: ");
                m[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(m));
            Console.ReadLine();
        }
    }
}
