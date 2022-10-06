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
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write($"{array[i]}");
        else Console.Write($"{array[i]}, ");
    }
    Console.Write(" ]");
}

int[,] myArr = Create2DArray(3, 4);
Print2DArray(myArr);
double[] myAverage = AverageOfArrayColumns(myArr);
PrintArray(myAverage);

double[] AverageOfArrayColumns(int[,] arr)
{
    double[] res = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr [j, i];  
        }
        res[i] = sum / arr.GetLength(0);
    }
    return res;
}
