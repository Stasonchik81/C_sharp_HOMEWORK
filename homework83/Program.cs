// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = InputIntData("Введите первое число");
int n = InputIntData("Введите второе число");
int res = Akkerman(m, n);
Console.WriteLine(res);

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else
    {
        if (m > 0 && n == 0) return Akkerman(m - 1, 1);
        else return Akkerman(m - 1, Akkerman(m, n - 1));
    }
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
