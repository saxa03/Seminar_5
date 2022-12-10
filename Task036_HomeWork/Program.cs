// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Console.Clear();
// Console.WriteLine("Введите размер массива");
// int size = int.Parse(Console.ReadLine());
// int[] array = new int[size];



// PrintArray(array);
// ArrayRandomNumbers(array);

// int[] ArrayRandomNumbers(int[] array)// масcив array заполняем случайными числами
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100,100);
//     }
//     return array;
// }

// int[] PrintArray(int[] array)//метод вывода массива
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//                 Console.Write(array[i] + " ");
//     }
//     return array;
//     Console.WriteLine();
// }
 Console.WriteLine("Введите размер массива");
 int size = int.Parse(Console.ReadLine());
 int[] arr = new int[size];

ArrayRandomNumbers(arr);
PrintArray(arr);




int[] ArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }return array;
}

int[] PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }return array;
    Console.WriteLine();
}
int SumIndex_Odd = 0;

for (int i = 1; i<arr.Length;i+=2)
{
    SumIndex_Odd = SumIndex_Odd + arr[i];
}
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {SumIndex_Odd}");