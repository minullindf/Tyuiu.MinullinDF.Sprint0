using Tyuiu.MinullinDF.Sprint0._2;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int t = 3;
        int l = 3;

        int sum = ClassWork.Add(t, l);
        Console.WriteLine("Сумма чисел: " + sum);
        Console.ReadKey();
    }
}