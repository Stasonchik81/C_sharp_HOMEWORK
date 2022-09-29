// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

// Задал для вывода в соответствии с образцом
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

Console.WriteLine("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] myArr = GetRandomArray(size, 1, 100);
PrintArray(myArr);
Console.WriteLine($" -> {Math.Round(GetMaxDouble(myArr) - GetMinDouble(myArr), 2)}");


// Генератор массива вещественных чисел заданной размерности
double[] GetRandomArray(int size, int min, int max)
{
    Random rnd = new Random();
    double[] arr = new double[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 2);
    }
    return arr;
}

// Функция вывода массива на экран
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

// Функция получения минимального значения в массиве
double GetMinDouble(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        min = array[i]<min ? array[i] : min;
    }
    return min;
}

// Функция получения максимального значения в массиве
double GetMaxDouble(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        max = array[i]>max ? array[i] : max;
    }
    return max;
}
