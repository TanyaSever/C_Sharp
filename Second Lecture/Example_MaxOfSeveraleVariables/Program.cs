// Определение максимума из 9 переменных 
// int Max(int ) - функция опр максимум
int Max(int arg1, int arg2, int arg3) //данный кусочек кода отвечает за поиск максимум из 3 чисел
{
  int result = arg1;
  if(arg2>result) result = arg2;
  if(arg3>result) result = arg3;
  return result;
}

int a1 = 250;
int b1 = 4;
int c1 = 15;
int a2 = 13;
int b2 = 1;
int c2 = 0;
int a3 = 52;
int b3 = 10;
int c3 = 14;

//Стихийное решение:
//int max = a1; //закладываем некоторую переменную максимум, куда ложим значение первого аргумента
//if(b1 > max) max = b1;
//if(c1 > max) max = c1;
//if(a2 > max) max = a2;
//if(b2 > max) max = b2;
//if(c2 > max) max = c2;
//if(a3 > max) max = a3;
//if(b3 > max) max = b3;
//if(c3 > max) max = c3;
//Console.WriteLine(max);

//int max1 = Max(a1,b1,c1); //max 1 - это наибольшее из первых трех чисел
//int max2 = Max(a2,b2,c2); 
//int max3 = Max(a3,b3,c3);
//int max = Max(max1, max2, max3);  //max - это наибольшее из наибольших

int max = Max(Max(a1,b1,c1), 
  Max(a2,b2,c2), 
  Max(a3,b3,c3)); //здесь можно по строчкам не разносить
  

Console.WriteLine("Самое большое число: ");
Console.WriteLine(max);

