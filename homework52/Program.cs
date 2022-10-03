// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите данные: ");
Console.Write("b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"b1={b1}, k1={k1}, b2={b2}, k2={k2}");
double[] intPoint = IntersectionPoint(b1, k1, b2, k2);

double[] IntersectionPoint(int b1, int k1, int b2, int k2)
{
    double x, y;
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    double[] point = new double[2] {x, y};
    return point;
}
Console.WriteLine($"Точка пересечения двух прямых: y = {k1} * x + {b1} и y = {k2} * x + {b2} => ({intPoint[0]}; {intPoint[1]})");
