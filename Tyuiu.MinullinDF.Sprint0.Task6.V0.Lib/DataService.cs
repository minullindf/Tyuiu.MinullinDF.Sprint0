using System.Net.Http.Headers;

namespace Tyuiu.MinullinDF.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static int AdditionArray(int[] list) 
        {
            int a = 0;
            for (int i = 0; i < list.Length; i++)
            {
                a += list[i];
            }
            return a;
        }

        public static int SubtractionArray(int[] list)
        {
            int total = 0;
            int index = 0;
            while (index < list.Length)
            {
                total -= list[index];
                index++;
            }
            return total;
        }

        public static int MultiplicationArray(int[] list)
        {
            int total = 1;
            int index = 0;

            do {
                total *= list[index];
                index++;
            } while (index < list.Length);

            return total;
        }
    }
}
