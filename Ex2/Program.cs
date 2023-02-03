//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] FillArr(int size, int leftr, int rightr)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftr, rightr + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int[] array = FillArr(4,1,10);
PrintArray(array);

int result = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        result += array[i];
    }
}
System.Console.WriteLine(result);