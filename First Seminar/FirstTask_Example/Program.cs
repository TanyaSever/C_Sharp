//Первое задание. Показывает преподователь
Console.WriteLine("Введи любое число:  ");
string numberA = Console.ReadLine()!;//успокаиваем программу с помощью ! ReadLine считывает только строки
int num = int.Parse(numberA);//преобразование в целочисленное значение из строкового
Console.WriteLine("А это его квадрат: ");
Console.Write(num*num);