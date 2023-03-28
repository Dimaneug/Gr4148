Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()??"0");

if ((num / 100)>0) 
    while (num>99) {
        if (num < 1000)
            Console.WriteLine("Третья цифра - {0}", num%10);
        num /= 10;
    }
else
    Console.WriteLine("Третьей цифры нет");
