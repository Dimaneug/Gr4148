// Принимает 3 числа и проверяет, 
// может ли существовать треугольник с такими сторонами

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Проверка существования треугольника по 3 сторонам
bool CheckTriangleExist(int a, int b, int c)
{
    return (a + b > c) && (b + c > a) && (c + a > b);
}

int a = ReadData("a: ");
int b = ReadData("b: ");
int c = ReadData("c: ");
Console.WriteLine(CheckTriangleExist(a,b,c)?"Существует":"Не существует");
