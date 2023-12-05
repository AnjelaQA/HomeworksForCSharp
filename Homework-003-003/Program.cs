
using System.Globalization;

double[] FillArray(int size)
{
    double[] array = new double[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        double randomNumber = Math.Round(random.NextDouble() * 10, 2);
        array[i] = randomNumber;
    }
    return array;
}

void PrintArray(double[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i] + " ");
    }
}

double MaxMinusMin(double[] Array)
{
    double Max = Array[0];
    double Min = Array[0];
    double result = 0;


    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > Max)
        {
            Max = Array[i];

        }
        // Console.WriteLine($"MAX: {Max}");
    }

    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] < Min)
        {
            Min = Array[i];

        }
        // Console.WriteLine($"MIN: {Min}");
    }

    result = Max - Min;


    return result;
}

int arrayLength = 10;
double[] NewArray = FillArray(arrayLength);
PrintArray(NewArray);
Console.WriteLine();
Console.WriteLine($"Результат: {MaxMinusMin(NewArray)}");
