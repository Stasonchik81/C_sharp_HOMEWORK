// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// A (m x n) * B (n x k) = C (m x k) 
// Cij = sum(Ain * Bnj)
Console.WriteLine("Введите размер первой матрицы");
int firstM = InputIntData("Введите количество строк");
int firstN = InputIntData("Введите количество столбцов");
Console.WriteLine("Введите размер второй матрицы");
int secondN = InputIntData("Введите количество строк");
int secondK = InputIntData("Введите количество столбцов");
if (firstN == secondN)
{
    int[,] matrixA = CreateMatrix(firstM, firstN, 1, 5);
    int[,] matrixB = CreateMatrix(secondN, secondK, 1, 5);
    PrintMatrix(matrixA);
    Console.WriteLine();
    PrintMatrix(matrixB);
    int[,] result = MultiMatrix(matrixA, matrixB);
    Console.WriteLine();
    Console.WriteLine("Результат перемножения матриц:");
    PrintMatrix(result);

}
else Console.WriteLine("Размерность матриц не позволяет выполнить перемножение!");


/// <summary>
/// Ввод целочисленных данных
/// </summary>
/// <param name="message">Выводимое сообщение</param>
/// <returns>целое число (вводимые данные)</returns>
int InputIntData(string message)
{
    Console.Write($"{message} : ");
    int data = Convert.ToInt32(Console.ReadLine());
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
/// Перемножение матриц
/// </summary>
/// <param name="m1">матрица 1</param>
/// <param name="m2">матрица 2</param>
/// <returns>матрица как результат произведения m1 и m2</returns>
int[,] MultiMatrix(int[,] m1, int[,] m2)
{
    int n = m1.GetLength(1);
    int[,] resMatrix = new int[m1.GetLength(0), m2.GetLength(1)];
    for (int i = 0; i < resMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < n; k++)
            {
                resMatrix[i, j] += m1[i, k] * m2[k, j];
            }
        }
    }
    return resMatrix;
}