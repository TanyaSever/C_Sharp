Console.Write("У нас есть случайное двухзначное число: ");
int MaxNum(int number)
{
  Console.WriteLine(number);
  int num1 = number/10;
  int num2 = number%10;
  if (num1>num2)return num1;
  return num2;
};
int result = MaxNum(new Random().Next(10, 100));
Console.Write("Наибольшее цифра в данном числе это: " );
Console.Write(result);

 