// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

double[,] Create2DArray(int rows, int columns)
{
    double[,] arr = new double[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = Math.Round(rnd.NextDouble() * 20 - 10, 1);;
        }
    }
    return arr;
}

void Print2DArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j], 4}, ");
            else Console.Write($"{arr[i, j], 4}");
        }
         Console.WriteLine("  |");
    }
}

double[,] myArray = Create2DArray(3, 4);
Print2DArray(myArray);
