
using System.Globalization;

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
    }
    return array;
}

void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i] + " ");
    }
}

int FindNumbersFrom20to90(int[] Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] % 2 ==0)
        {
    
            count++;

        }

    }
    return count;
}

int arrayLength = 10;
int[] NewArray = FillArray(arrayLength);
PrintArray(NewArray);
Console.WriteLine();
Console.WriteLine($"Результат: {FindNumbersFrom20to90(NewArray)}");
