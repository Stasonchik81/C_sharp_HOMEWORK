// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = InputIntData("Введите 1 границу диапазона");
int n = InputIntData("Введите 2 границу диапазона");
int summ;
if (m > n) summ = SumInRange(m, n);
else summ = SumInRange(n, m);
Console.WriteLine(summ);

int SumInRange(int num1, int num2)
{
    int sum = num1;
    if (num1 == num2) return sum;
    return sum += SumInRange(num1 - 1, num2);
    num1++;
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

