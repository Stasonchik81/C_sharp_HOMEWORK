// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] myArray = GetRandomArray(8, 10);
PrintArray(myArray);

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if(i == array.Length - 1) Console.Write($"{array[i]}");
        else Console.Write($"{array[i]}, ");
    }
    Console.Write(" ]");
}

int[] GetRandomArray(int size, int max)
{
    Random rnd = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, max);
    }
    return arr;
}
