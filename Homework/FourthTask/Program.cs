Console.WriteLine("Введите число");
string numberA = Console.ReadLine()!;
int a = int.Parse(numberA);
int b = 2;
while(b <= a)
{
    Console.Write($"{b} ");
    b +=2;
}
