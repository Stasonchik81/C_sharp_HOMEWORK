// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number != 0) Console.WriteLine($"Сумма цифр в числе {number} - {SumOfDigits(Math.Abs(number))}");
else Console.WriteLine("Введён '0' и складывать нечего");

int SumOfDigits(int num)
{
    int res = 0;
    do
    {
        res += num % 10;
        num /= 10;
    } while (num > 0);
    return res;
}