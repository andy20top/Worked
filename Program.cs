int[] array = {1, 5, 4, 3, 6, 8, 9, 10};

void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}

PrintArray(array);

void SelectionArray (int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i+1; j < arr.Length; j++)
        {
            if (arr[j] > arr[maxPosition]) maxPosition = j;
        }

        int temp = arr[i];
        arr [i] = arr[maxPosition];
        arr[maxPosition] = temp;    
    }
}

SelectionArray(array);
PrintArray(array);