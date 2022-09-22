// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100) 
{
    Console.WriteLine("Третьей цифры нет");
    return;
}
num = get3Dig(num);
Console.WriteLine(getThirdDigit(num));


int getThirdDigit(int num)
{
    return num % 10;
}

int get3Dig(int num)
{
    while (num>=1000)
    {
        num /= 10;
    }
    return num;
}