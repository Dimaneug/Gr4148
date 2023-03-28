int num = int.Parse(Console.ReadLine()??"0");
bool res = (num%7==0 && num%23==0);

if (res) 
    Console.WriteLine("Число {0} кратно 7 и 23", num);
else
    Console.WriteLine("Число {0} не кратно 7 и 23", num);
