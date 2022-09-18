// homework _1 (Задача 2):
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2) Console.WriteLine($"Число {num1} - большее.");
else if (num2 > num1) Console.WriteLine($"Число {num2} - большее.");
else Console.WriteLine("Числа равны!");

