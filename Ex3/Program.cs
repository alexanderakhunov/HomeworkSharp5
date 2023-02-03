//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] fillArr(int size, int lefr, int rightr)
{
    int[] arr = new int[size];
    Random rand = new Random();
    //double temp = Math.Round(rand.Next(lefr,rightr + 1) + rand.NextDouble(),3);
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(lefr,rightr + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int MaxMin(int[] arr)
{
    int Max = arr[0];
    int Min = arr[0];
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (Max < arr[i])
        {
            Max = arr[i];
        }
        else
        {
            Min = arr[i];
        }
        result = Max - Min;
    }
    System.Console.WriteLine(result);
    return result;
}



int[] array = fillArr(5, 1, 10);
PrintArray(array);
MaxMin(array);