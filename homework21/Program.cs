// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

// Is number palindrome? Я попытался сделать универсальную формулу....
// (применима для чисел от -2147483647 до 2147483647)

// Ввод данных
Console.WriteLine("Введите число: ");
try
{
    int number = Convert.ToInt32(Console.ReadLine());
    // Проверка на палиндром
    if (Math.Abs(number) < int.MaxValue)
    {
        string message = isPalindrom(number) ? "ДА" : "НЕТ";
        Console.WriteLine(message);
    }
    else
    {
        Console.WriteLine($"Число {number} больше (2147483647) либо меньше (-2147483647)допустимого значения!");
    }
}
catch (System.Exception)
{
    Console.WriteLine($"Ошибка ввода данных!");
}


// Функция подсчёта разрядности числа
int digitsCounter(int num)
{
    int count = 0;
    while (Math.Abs(num) > 10)
    {
        num /= 10;
        count++;
    }
    return count;
}

// Функция проверки числа на палиндром
// (функция подходит для чисел не превышающих разрядность int32)

bool isPalindrom(int num)
{
    int count = digitsCounter(num);
    // Console.WriteLine($"Count: {count}");
    // Находим центр числа (должен вычислятся не зависимо от чётного или нечётного количества цифр)
    int centre = (int)Math.Round((decimal)count / 2, MidpointRounding.AwayFromZero);
    // Console.WriteLine($"c: {centre}");
    // в цикле до середины сравниваем попарно цифры (первую и последнюю)
    for (int i = 0; i < centre; i++)
    {
        int first = num / Convert.ToInt32(Math.Pow(10, count - i)) % 10;
        int last = num / Convert.ToInt32(Math.Pow(10, i)) % 10;
        if (first != last) return false;
    }
    return true;
}


