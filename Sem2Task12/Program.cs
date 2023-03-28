int num1 = int.Parse(Console.ReadLine()??"0");
int num2 = Convert.ToInt32(Console.ReadLine());
bool res = (num1%num2==0);
if (res) 
    Console.WriteLine("Первое число кратно второму");
else
    Console.WriteLine("Первое число не кратно второму");