Console.WriteLine("Введи любое число:  ");
string numberA = Console.ReadLine()!;
int a = int.Parse(numberA);
Console.WriteLine("И еще одно введи:  ");
string numberB = Console.ReadLine()!;
int b = int.Parse(numberB);

if(b*b == a)
{
    Console.WriteLine("a это b в квадрате!");
}
else if(a*a == b)
{
    Console.WriteLine("А тут все наоборот, b это a в квадрате");
}
else
{
    Console.WriteLine("Эти два числа рандомны");
}

//если писать console с маленькой буквы, то чудес не происходит