int num1 = int.Parse(Console.ReadLine()??"0");
int num2 = int.Parse(Console.ReadLine()??"0");

void SqrtTest(int a, int b) {
    if (a == b*b)
        Console.WriteLine(a+" квадрат "+b);
    else
        Console.WriteLine(a+" не квадрат "+b);
}

SqrtTest(num1, num2);
SqrtTest(num2, num1);