// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] Create2DArray(int rows, int columns)
{
    int[,] arr = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = rnd.Next(1, 10);
        }
    }
    return arr;
}

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],2}");
        }
        Console.WriteLine();
    }
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

int GetElementOfArray(int[,] arr, int row, int col)
{
    return arr[row - 1, col - 1];
    // return arr[row, col];
}

// Ввод координат элемента осуществлять с 1.
// Для ввода строк и столбцов с "0" изменить функцию GetElementOfArray

int[,] myArray = Create2DArray(3, 4);
Print2DArray(myArray);
Console.Write("Введите координаты элемента массива через пробел: ");
string input = Console.ReadLine();

int[] coordinates = input.Split(' ').Select(int.Parse).ToArray();
PrintArray(coordinates);

if (coordinates[0] > myArray.GetLength(0) || 
    coordinates[1] > myArray.GetLength(1))
    Console.Write(" Такого числа в массиве нет");
else Console.Write($" -> {GetElementOfArray(myArray, coordinates[0], coordinates[1])}");

