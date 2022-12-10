// Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();
Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());
int k = 0;
int[] arr = new int[size];
ArrayRandomNumbers(arr);
PrintArray(arr);


// считаем четные
for (int i = 0; i < arr.Length; i++)
{
     if(arr[i] % 2 == 0)
     k++;
}
Console.Write($"В массиве -> {k} чётных чисел");

int[] ArrayRandomNumbers(int[] array)// масcив array заполняем случайными трехзначными числами
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(101,1000);
    }
    return array;
}

int[] PrintArray(int[] array)//метод вывода массива
{
    for(int i = 0; i < array.Length; i++)
    {
         
        Console.Write($"{string.Join("",array[i])} ");
    }
    return array;
    Console.WriteLine();
}