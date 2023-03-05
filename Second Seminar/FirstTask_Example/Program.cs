//отображать посл цифру трехзначного числа
Console.Write("У нас есть трехзначное число: ");
int numbA = new Random().Next(100, 1000);
//Console.Write("Последняя цифра этого числа: ");
//Console.Write(numbA % 10); //% возвращает посл цифру от деления

int TakeNum(int numbA)
{
  Console.WriteLine(numbA);
  return numbA % 10;
}

int result = TakeNum(numbA);
Console.Write("Последняя цифра этого числа: ");
Console.Write(result);