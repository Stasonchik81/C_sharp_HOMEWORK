// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа разделяя пробелом: ");
string input = Console.ReadLine();
int[] numbers = input.Split(' ').Select(int.Parse).ToArray();


PrintArray(numbers);
Console.WriteLine($" => {CountPositiveNum(numbers)}");

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write($"{array[i]}");
        else Console.Write($"{array[i]}, ");
    }
    Console.Write(" ]");
}
int CountPositiveNum(int[] arr)
{
    int count = 0;
    foreach (var item in arr)
    {
        if(item>0) count++;
    }
    return count;
}