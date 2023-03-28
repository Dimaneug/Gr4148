Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine()??"0");

if (num>99 && num<1000) {
    Console.WriteLine("Вторая цифра - {0}", (num/10)%10);
}
else
    Console.WriteLine("Вы ввели не трёхзначное число!");
