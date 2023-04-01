// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
string? firstLine = Console.ReadLine();

Console.Write("Введите второе число: ");
string? secondLine = Console.ReadLine();

Console.Write("Введите третье число: ");
string? thirdLine = Console.ReadLine();

if (firstLine != null && secondLine != null && thirdLine != null) {
    int firstNum = int.Parse(firstLine);
    int secondNum = int.Parse(secondLine);

    if (secondNum > firstNum) firstNum = secondNum;
    secondNum = int.Parse(thirdLine);
    if (firstNum > secondNum) Console.WriteLine("Наибольшее число - {0}", firstNum);
    else Console.WriteLine("Наибольшее число - {0}", secondNum);
}
