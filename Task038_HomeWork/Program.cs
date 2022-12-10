// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.

// [3 7 22 2 78] -> 76
Console.WriteLine("Введите размер массива");
 int size = int.Parse(Console.ReadLine());
double[] arr = new double[size];
double min = arr[0];
double max = arr[0];


ArrayRandomNumbers(arr);
PrintArray(arr);



for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    else if (arr[i] < min)
    {
        min = arr[i];
    }
}


Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");

double[] ArrayRandomNumbers(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }return array;
}

double[] PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }return array;
    Console.WriteLine();
}
