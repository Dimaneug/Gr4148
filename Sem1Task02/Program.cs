Console.Write("Введите первое число: ");
string? firstLine = Console.ReadLine();

Console.Write("Введите второе число: ");
string? secondLine = Console.ReadLine();

if (firstLine != null && secondLine != null) {
    int firstNumber = int.Parse(firstLine);
    int secondNumber = int.Parse(secondLine);

    if (firstNumber > secondNumber) Console.WriteLine("Большее число - {0}", firstNumber);
    else Console.WriteLine("Большее число - {0}", secondNumber);
}