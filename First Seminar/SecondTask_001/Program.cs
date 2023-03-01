Console.WriteLine("Введи любое число от 1 до 7:  ");
string numberA = Console.ReadLine()!;//успокаиваем программу с помощью ! ReadLine считывает только строки
int num = int.Parse(numberA);
if(num == 1)
{
    Console.WriteLine("1 is for Monday");
}
else if(num == 2)
{
    Console.WriteLine("2 is for Tuesday");
}
else if(num == 3)
{
    Console.WriteLine("3 is for Wednesday");
}
else if(num == 4)
{
    Console.WriteLine("4 is for Thursday");
}
else if(num == 5)
{
    Console.WriteLine("5 is for Friday.I love Friday!");
}
else if(num == 6)
{
    Console.WriteLine("6 is for Saturday");
}
else if(num == 7)
{
    Console.WriteLine("7 is for Sunday");
}