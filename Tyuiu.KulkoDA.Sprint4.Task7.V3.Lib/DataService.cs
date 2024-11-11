using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KulkoDA.Sprint4.Task7.V3.Lib
{
    public class DataService : ISprint4Task7V3
    {
        public int Calculate(int n, int m, string value)
        {
            int count = 0;
            int[,] mt = new int[n, m];
            for(int i=0;i<n;i++)
            {
                for (int j=0;j<m;j++)
                {
                    mt[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mt[i,j]%2!=0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
