namespace Zadanie_05;

public class NumberSearcher
{
    private int[] numbers;
    public int maxValue;
    private object locker = new object();
    private int threadCount = 4;

    public NumberSearcher(int[] numbers)
    {
        this.numbers = numbers;
        this.maxValue = int.MinValue;
    }

    public void FindMax()
    {
        Thread[] threads = new Thread[threadCount];
        int rangeSize = numbers.Length / threadCount;

        for (int i = 0; i < threadCount; i++)
        {
            int start = i * rangeSize;
            int end = (i == threadCount - 1) ? numbers.Length : start + rangeSize; // ostatni wątek bierze resztę

            threads[i] = new Thread(() => FindMaxInRange(start, end));
            threads[i].Start();
        }

        // Czekaj na zakończenie wszystkich wątków
        foreach (Thread t in threads)
        {
            t.Join();
        }

        Console.WriteLine($"Maksymalna wartość to: {maxValue}");
    }

    private void FindMaxInRange(int start, int end)
    {
        int localMax = int.MinValue;

        for (int i = start; i < end; i++)
        {
            if (numbers[i] > localMax)
            {
                localMax = numbers[i];
            }
        }

        // Synchronizacja przy aktualizacji globalnego maxValue
        lock (locker)
        {
            if (localMax > maxValue)
            {
                maxValue = localMax;
            }
        }
    }
}