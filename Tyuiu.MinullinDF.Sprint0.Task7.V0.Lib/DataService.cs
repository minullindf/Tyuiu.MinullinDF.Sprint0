namespace Tyuiu.MinullinDF.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] list1, int[] list2)
        {
            int[] resultArray = new int[5];
            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = list1[i] + list2[i];
            }
            return resultArray;
        }
    }
}
