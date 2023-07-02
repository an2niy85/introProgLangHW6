// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
System.Console.WriteLine("Введите коэффициенты двух линейных уровнений (y = k1 * x + b1, y = k2 * x + b2) через запятую ( 1, 2, 3, 4)");
string[] ratios = Console.ReadLine().Split(", ");
if ( ratios[0] = ratios[2])
{
    System.Console.WriteLine("Они не пересекуться");
    return;
}
int x = (ratios[3] - ratios[1])/(ratios[0] - ratios[2]);
int y = ratios[0] * x + ratios[1];
System.Console.WriteLine($"x = {x}, y = {y}");