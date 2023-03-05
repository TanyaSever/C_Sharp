void MultNumber(int num1)
{
  if (num1 % 7 == 0 & num1%23 == 0) 
    Console.WriteLine("Число кратно одновременно и 7 и 23");
  else
    Console.WriteLine("Число некратно одновременно 7 и 23");
}
int A = int.Parse(Console.ReadLine())!;
MultNumber(A);
