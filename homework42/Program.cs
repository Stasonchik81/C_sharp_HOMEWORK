// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArr = GetRandomArray(size, -100, 100);
PrintArray(myArr);
Console.WriteLine($" -> {SumOfOdds(myArr)}");

int SumOfOdds(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        sum +=arr[i];
    }
    return sum;
}

int[] GetRandomArray(int size, int min, int max)
{
    Random rnd = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write($"{array[i]}");
        else Console.Write($"{array[i]}, ");
    }
    Console.Write(" ]");
}

