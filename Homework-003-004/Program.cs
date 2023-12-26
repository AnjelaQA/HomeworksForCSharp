int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 111);
    }
    return array;
}

void PrintArray(int[] Arr){
    for(int i = 0; i < Arr.Length; i++){
        Console.Write(Arr[i] + " ");
    }
}

int[] array = FillArray(10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"0 элемент:{array[0]}");