﻿// array - по английски массив
// Определение максимума из 9 переменных 
// int Max(int ) - функция опр максимум
int Max(int arg1, int arg2, int arg3) 
{
  int result = arg1;
  if(arg2>result) result = arg2;
  if(arg3>result) result = arg3;
  return result;
}
//индексы:     0  1  2  3 4   5 6  7  8
int[] array = {17,2,13,43,503,6,7,81,9}; //ввод какого-то массива, array - это имя массива
array[0]=12; //обращаемся к массиву и говорим, что значению массива с индексом 0 присвоить значение 12
//Console.WriteLine(array[4]);//обращаемся к массиву и получаем значение соотвествующего элемента по указанному индексу

int max = Max(
  Max(array[0], array[1], array[2]),
  Max(array[3], array[4], array[5]),
  Max(array[6], array[7], array[8])
);
Console.WriteLine(max);
