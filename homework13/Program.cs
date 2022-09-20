// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

string[] days = new[] { "monday", "tuesday", "wensday", "thirsday", "friday", "satueday", "sunday" };
Console.Write("Введите номер дня недели: ");

int num = Convert.ToInt32(Console.ReadLine());

if (num > 0 && num < 7)
{
    Console.WriteLine($"Сегодня {days[num - 1]}!");
    if(num == 6 || num == 7)Console.WriteLine("Сегодня выходной!");
    else Console.WriteLine("Опять на работу :(");
}
else Console.Write("Такого дня не существует");

