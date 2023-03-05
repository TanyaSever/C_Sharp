//метод void - не возвращает ничего, тогда в коде нельзя использовать оператор result 
int[] array = new int[10];
void FillArray(int[] collection)
{
  int length = collection.Length; //определяем длину массива
  int index = 0;
  while (index < length)
  {
    collection[index] = new Random().Next(1, 10);
    index++;
  }
}

void PrintArray(int[] coll)
{
  int count = coll.Length;
  int position = 0;
  while (position < count)
  {
    Console.WriteLine(coll[position]);
    position++;
  }
}
//новый массив в котором по умолчанию 10 элементов
FillArray(array);
PrintArray(array);

//определили массивчик из 10 элементов, затем вызвали метод FillArray который заполнил нам массив 
//затем метод PrintArray нам его распечатал
