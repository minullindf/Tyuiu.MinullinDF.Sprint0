using Tyuiu.MinullinDF.Sprint0.Task6.V0.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] NumsArray = new int[] { 1, 2, 3, 4, 5 };

        Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(NumsArray));
        Console.WriteLine("Разность элементов массива = " + DataService.SubtractionArray(NumsArray));
        Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(NumsArray));

        Console.ReadKey();
    }
}