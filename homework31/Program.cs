// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите два числа: ");
Console.Write("Основание: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Степень: ");
int powB = Convert.ToInt32(Console.ReadLine());
if (numberA > 0 && powB > 0)
{
    Console.WriteLine($"основание - {numberA}, степень - {powB}, result: {Pow(numberA, powB)}");
}
else
{
    Console.WriteLine("Ошибка ввода данных");
}

int Pow(int a, int b)
{
    int res = 1;
    while (b > 0)
    {
        res *= a;
        b--;
    }
    return res;
}

