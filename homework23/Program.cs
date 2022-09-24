// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void printListCubing(int num)
{
    Console.WriteLine($"Таблица кубов числа {num}");
    for (int i = 1; i <= num; i++)
    {
        // if(i == num)Console.Write($"{Math.Pow(i, 3)}"); вывод в строку
        // else Console.Write($"{Math.Pow(i, 3)},");

        Console.WriteLine($"{i} | {Math.Pow(i, 3)}");
    }
}

printListCubing(number);
