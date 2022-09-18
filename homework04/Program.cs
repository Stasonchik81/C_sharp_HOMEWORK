// homework _1 (Задача 8):
// even numbers from 1 to N

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

// _______Вывод в обратном порядке_______
// while (num > 0)
// {
//     if (num % 2 == 0)
//     {
//         Console.Write($"{num}, ");
//     }
//     num--;
// }

for (int i = 1; i <= num; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i);
        if(i!=num)
        {
            Console.Write(", ");
        }
    }
}

