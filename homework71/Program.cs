// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int m = InputIntData("Введите размер массива m");
int n = InputIntData("Введите размер массива n");
int[,] my2DArray = CreateMatrix(m, n, 1, 10);
PrintMatrix(my2DArray);
ToSort2DArray(my2DArray);
Console.WriteLine();
PrintMatrix(my2DArray);



/// <summary>
/// Ввод целочисленных данных
/// </summary>
/// <param name="message">Выводимое сообщение</param>
/// <returns>целое число (вводимые данные)</returns>
int InputIntData(string message)
{
    int data = default;
    Console.WriteLine($"{message}");
    data = Convert.ToInt32(Console.ReadLine());
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
/// Сортировка двумерного массива методом пузырька
/// </summary>
/// <param name="arr">двумерный массив целых чисел</param>
void ToSort2DArray(int[,] arr)
{
    int temp;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, k] > arr[i, j])
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }

}

