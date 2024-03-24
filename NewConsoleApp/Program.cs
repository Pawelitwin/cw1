
using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        double average = CalculateAverage(numbers);
        Console.WriteLine("Średnia wynosi: " + average);
    }

    static double CalculateAverage(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Tablica jest pusta lub null.");
        }

        int sum = 0;
        foreach (int numm in array)
        {
            sum += numm;
        }

        return (double)sum / array.Length;
    }

    static int FindMax(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Tablica jest pusta lub null.");
        }

        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        return max;
    }



