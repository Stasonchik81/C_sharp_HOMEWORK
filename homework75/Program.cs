// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

string[,] myArray = CreateMatrix(4, 4);
PrintMatrix(myArray);


string[,] CreateMatrix(int rows, int columns)
{
    string[,] arr = new string[rows, columns];
    int count = 0;
    for (int i = 0; i < rows ; i++)
    {
       for (int j = 0; j < columns; j++)
       {
        arr[i, j] = Counter(count);
        count++;
       }
    }
    return arr;
}

string Counter(int c)
{
    if(c<10)return new String($"0{c}");
    else return new String($"{c}");
}

/// <summary>
/// Печать двумерного массива
/// </summary>
/// <param name="matrix">двумерный массив целых чисел</param>
void PrintMatrix(string[,] matrix)
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
