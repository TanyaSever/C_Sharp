//Первое задание. Показывает преподователь
Console.WriteLine("Введи любое число:  ");
string numberA = Console.ReadLine()!;//успокаиваем программу с помощью !
int num = int.Parse(numberA);
Console.WriteLine("А это его квадрат: ");
Console.Write(num*num);