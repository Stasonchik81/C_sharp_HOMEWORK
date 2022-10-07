// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void PrintArray(double[] array)
{
    foreach (double item in array) Console.Write($"{item} ");
}

int[,] myArr = Create2DArray(3, 4);
Print2DArray(myArr);
double[] myAverage = AverageOfColumnsInArray(myArr);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(myAverage);

double[] AverageOfColumnsInArray(int[,] arr)
{
    double[] res = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr [j, i];  
        }
        res[i] = Math.Round(sum / arr.GetLength(0), 1, MidpointRounding.ToZero);
    }
    return res;
}
