﻿Console.WriteLine("Введите 3-х значное число");
string? number = Console.ReadLine();

if (number != null) {
    int lastNum = int.Parse(number) % 10;

    Console.WriteLine("Последняя цифра введённого числа:");
    Console.WriteLine(lastNum);
}