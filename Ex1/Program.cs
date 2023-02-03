int [] FillArr(int size, int leftr, int rightr)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftr, rightr + 1);
    }
    return arr;
}

void PrintArray(int [] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int arrayChet(int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int [] array = FillArr(10,99,999);
PrintArray(array);
System.Console.WriteLine(arrayChet(array));