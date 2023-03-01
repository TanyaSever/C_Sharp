// Напишите программу которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежкутке от -N до N
Console.WriteLine("Введите число");
string numberA = Console.ReadLine()!;
int a = int.Parse(numberA);
int b = -a;
while(b <= a)
{
    Console.Write($"{b} ");
    b++;
}