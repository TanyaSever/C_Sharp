//Число называют кратным, если оно делится на данное число нацело, без остатка
void Div(int num1, int num2)
{
  if (num1 % num2 == 0)
    Console.WriteLine("Первое число кратно второму");
  else
    Console.WriteLine("Некратно, остаток от деления равен " + num1 % num2);
}
int A = int.Parse(Console.ReadLine())!;
int B = int.Parse(Console.ReadLine())!;
Div(A, B);

