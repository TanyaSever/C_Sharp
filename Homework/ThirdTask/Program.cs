Console.WriteLine("Введи любое число:  ");
string numberA = Console.ReadLine()!;
int x = int.Parse(numberA);
if (x % 2 == 0) Console.WriteLine("Данное число является чётным");
else Console.WriteLine("Это число нечётное");