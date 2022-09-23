// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

// Is number palindrome? Я попытался сделать универсальную формулу

// Ввод данных
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// Проверка на палиндром
string message = isPalindrom(number) ?  "ДА" : "НЕТ";
Console.WriteLine(message);

// Функция подсчёта разрядности числа
int digitsCounter(int num)
{
    int count = 0;
    while (num>10)
    {
        num /=10;
        count++;
    }
    return count;
}

// Функция проверки числа на палиндром

bool isPalindrom(int num)
{
    int count = digitsCounter(num);
    // Находим центр числа (должен вычислятся не зависимо от чётного или нечётного количества цифр)
    double centre = (double)count/2;
    int c = (int)Math.Round(centre, MidpointRounding.AwayFromZero);
    // в цикле до середины сравниваем попарно цифры (первую и последнюю)
    for (int i = 0; i < c; i++)
    {
        int first = Convert.ToInt32(num/Math.Pow(10, count-i)) % 10;
        int last = Convert.ToInt32(Math.Truncate(num/Math.Pow(10, i))) % 10;
        if(first != last) return false;
    }
    return true;
}


