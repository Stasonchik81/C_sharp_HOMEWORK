// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.WriteLine("Заполните размеры матрицы");
int firstD = InputIntData("Введите измерение а");
int secondD = InputIntData("Введите измерение b");
int thirdD = InputIntData("Введите измерение c");

// создаём список для хранения уникальных значений
List<int> myRandomList = new List<int> ();

int[,,] myMatrix = GenerateUnique3DArray(firstD, secondD, thirdD, 10, 100);
Print3DArray(myMatrix);

/// <summary>
/// генератор уникального случайного числа
/// </summary>
/// <param name="min">минимальное значение диапазона</param>
/// <param name="max">максимальное значение диапазона</param>
/// <param name="x">список уникальных значений</param>
/// <returns>уникальное число</returns>
int UniqueRandomInt(int min, int max, List<int>x)
{
    var rnd = new Random();
    int myNumber;
    do
    {
       myNumber = rnd.Next(min, max);
    } while (x.Contains(myNumber));
    return myNumber;
}

/// <summary>
/// генератор трёхмерного массива уникальных целых чисел
/// </summary>
/// <param name="a">размерность 1</param>
/// <param name="b">размерность 2</param>
/// <param name="c">размерность 3</param>
/// <param name="min">нижняя граница диапазона целых чисел</param>
/// <param name="max">верхняя граница диапазона целых чисел</param>
/// <returns>трёхмерный массив целых чисел</returns>
int[,,] GenerateUnique3DArray(int a, int b, int c, int min, int max)
{
    int[,,] matrix = new int[a, b, c];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < c; k++)
            {
                int rnd = UniqueRandomInt(min, max, myRandomList);
                myRandomList.Add(rnd);
                matrix[i, j, k] = rnd;
            }
        }
    }
    return matrix;
}

/// <summary>
/// Печать трёхмерного массива
/// </summary>
/// <param name="arr">трёхмерный массив</param>
void Print3DArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($" {arr[i, j, k]}");
                Console.Write($"({i}, {j}, {k}) ");
            }
        }
        Console.WriteLine();
    }
}

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

