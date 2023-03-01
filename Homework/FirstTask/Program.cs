Console.WriteLine("Введи любое число:  ");
string numberA = Console.ReadLine()!;
int a = int.Parse(numberA);
Console.WriteLine("И еще одно введи:  ");
string numberB = Console.ReadLine()!;
int b = int.Parse(numberB);
if(b<a)
{
    Console.WriteLine("Ну получается, что первое число больше");
}
else if(b>a)
{
    Console.WriteLine("Выходит, что второе число больше");
}
else if(b == a)
{
    Console.WriteLine("Никто не круче, расходимся");
}