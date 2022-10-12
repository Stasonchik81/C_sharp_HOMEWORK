// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int number = InputIntData("Введите число N");
PrintNumbers(number);

void PrintNumbers(int n)
{
    if (n == 0) return;
    Console.Write($"{n} ");
    PrintNumbers(n - 1);
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

