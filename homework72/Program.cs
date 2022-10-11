// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int m = InputIntData("Введите размер массива m");
int n = InputIntData("Введите размер массива n");
int[,] my2DArray = CreateMatrix(m, n, 1, 10);
PrintMatrix(my2DArray);
int rowOfMinSum = FindMinRowIndex(my2DArray) + 1;
Console.WriteLine($"Строка с наименьшей суммой элементов -> {rowOfMinSum}.");


/// <summary>
/// Ввод целочисленных данных
/// </summary>
/// <param name="message">Выводимое сообщение</param>
/// <returns>целое число (вводимые данные)</returns>
int InputIntData(string message)
{
    int data = default;
    Console.Write($"{message} : ");
    data = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    return data;
}

/// <summary>
/// Генератор массива заданной размерности
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="columns">Колонки</param>
/// <param name="min">Минимальный размер элемента</param>
/// <param name="max">Максимальный размер элемента</param>
/// <returns>Двумерный массив</returns>
int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] arr = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = rnd.Next(min, max);
        }

    }
    return arr;
}

/// <summary>
/// Печать двумерного массива
/// </summary>
/// <param name="matrix">двумерный массив целых чисел</param>
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("  |");
    }
}

/// <summary>
/// Поиск индекса строки двумерного массива с наименьшей суммой элементов
/// </summary>
/// <param name="arr">двумерный массив целых чисел</param>
/// <returns>идекс строки</returns>
int FindMinRowIndex(int[,] arr)
{
    int minRowIndex = default;
    int minSum = SumOfRow(arr, minRowIndex);
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        int sum = SumOfRow(arr, i);
        if (sum < minSum) 
        {
            minSum = sum;
            minRowIndex = i;
        }
    }
    return minRowIndex;
}

/// <summary>
/// Нахождение суммы элементов строки двумерного массива
/// </summary>
/// <param name="arr">двумерный массив целых чисел</param>
/// <param name="row">индекс строки</param>
/// <returns>сумма элементов строки</returns>
int SumOfRow(int[,] arr, int rowIndex)
{
    int sum = default;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        sum += arr[rowIndex, i];
    }
    return sum;
}