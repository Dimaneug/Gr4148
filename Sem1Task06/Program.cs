// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
string? line = Console.ReadLine();

if (line != null) {
    int num = int.Parse(line);

    if (num % 2 == 0) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}