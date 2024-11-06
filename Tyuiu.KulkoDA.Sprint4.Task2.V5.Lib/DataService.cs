using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KulkoDA.Sprint4.Task2.V5.Lib
{
    public class DataService : ISprint4Task2V5
    {
        public int Calculate(int[] array)
        {
            int c = 1;
            int len = array.Length;
            for (int i = 0; i < len; i++)
            {
                if (array[i] % 2 == 0)
                    c *= array[i];
            }
            return c;
        }
    }
}
