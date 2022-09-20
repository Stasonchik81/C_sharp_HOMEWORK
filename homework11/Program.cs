// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 999 || num < 100) Console.WriteLine("Некорректный ввод!");
else Console.WriteLine(getSecondDigit(num));

int getSecondDigit(int num)
{
    return (num / 10) % 10;
}
