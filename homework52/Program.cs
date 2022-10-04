// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите данные: ");
Console.Write("b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"b1={b1}, k1={k1}, b2={b2}, k2={k2}");
double[] intPoint = IntersectionPoint(b1, k1, b2, k2);

double[] IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x, y;
    Console.WriteLine($"числитель = {b2 - b1}");
    Console.WriteLine($"знаменатель = {k1 - k2}");
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    double[] point = new double[2] {x, y};
    return point;
}
Console.WriteLine($"Точка пересечения двух прямых: y = {k1} * x + {b1} и y = {k2} * x + {b2} => ({intPoint[0]}; {intPoint[1]})");
