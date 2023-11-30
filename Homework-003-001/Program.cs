
int[] FillArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,101);
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

int[] FindNumbersFrom20to90(int[] Array)
{
    for(int i = 0; i < Array.Length; i++)
    {
        if(Array[i] > 19 && Array[i] < 91 )
        {
            Console.WriteLine(Array[i]);
        }
    }
    return Array;
}

int arrayLength = 10;
int[] NewArray = FillArray(arrayLength);
PrintArray(NewArray);
int[] numbers = FindNumbersFrom20to90(NewArray);


