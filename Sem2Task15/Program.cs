// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли 
// этот день выходным.

var daysOfWeek = new Dictionary<int, string>()
{
    [1] = "нет",
    [2] = "нет",
    [3] = "нет",
    [4] = "нет",
    [5] = "нет",
    [6] = "да",
    [7] = "да"
};

Console.Write("Введите день недели: ");
int day = int.Parse(Console.ReadLine()??"0");

if (0<day && day<8) 
    Console.WriteLine(daysOfWeek[day]);
else
    Console.WriteLine("Такого дня недели не существует");