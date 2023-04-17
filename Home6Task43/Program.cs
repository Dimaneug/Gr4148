// Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1, 
//y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// * Найдите площадь треугольника образованного пересечением 3 прямых

using System;

// Считываем k и b
(double k, double b) ReadEquation()
{
    Console.Write("Введите k: ");
    double k = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b: ");
    double b = Convert.ToDouble(Console.ReadLine());
    return (k, b);
}

// Нахождение пересечения прямых
(double x, double y) FindIntersection(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return (x, y);
}

// Нахождение расстояния между точками
double FindDistance(double x1, double y1, double x2, double y2)
{
    double temp = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
    return Math.Sqrt(temp);
}

// Нахождение площади треугольника
double FindTriangleSquare(double a, double b, double c)
{
    double p = (a + b + c) / 2;
    return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
}

(double k1, double b1) = ReadEquation();
(double k2, double b2) = ReadEquation();
(double k3, double b3) = ReadEquation();
(double x1, double y1) = FindIntersection(k1, b1, k2, b2);
(double x2, double y2) = FindIntersection(k2, b2, k3, b3);
(double x3, double y3) = FindIntersection(k3, b3, k1, b1);
double a = FindDistance(x1, y1, x2, y2);
double b = FindDistance(x2, y2, x3, y3);
double c = FindDistance(x3, y3, x1, y1);
Console.WriteLine(FindTriangleSquare(a, b, c));


