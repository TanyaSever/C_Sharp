﻿// массив из N элементов
//             0  1 2  3  4  5  6  7 8  9
int[] array = {17,2,9,13,43,503,6,71,81,9};
int N = array.Length; //устанавливаем массив из N элементов
int find = 9;

int index = 0;
while (index < N)
{
  if(array[index] == find)
  {
    Console.WriteLine(index);
    break; //чтобы исключить что нам выдается несколько индексов с одинаковыми элементами
  }

  index++; //увеличваем значени индекса на каждом повторе
}

