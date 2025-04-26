namespace Zadanie_05;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] numbers = new int[1000];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(0, 10000);
        }

        var searcher = new NumberSearcher(numbers);
        searcher.FindMax();
        Console.WriteLine(searcher.maxValue);
        
    }
}