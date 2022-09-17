
// **********
// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька.
//  Реализовать невозрастающую сторировку.
// [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
// [1,2,2,3,2] -> [3, 2, 2, 2, 1]

int[] GetArray()
{
     int h = 20;
     int[] res = new int[h];

     for (int i = 0; i < h; i++)
     {
          res[i] = new Random().Next(10, 100);
     }
     return res;
}

int[] arra = GetArray();
Console.WriteLine(String.Join(", ", arra));

int[] Ordering(int[] ar)
{
     int k = ar.Length;
     for (int i = 0; i < k; i++)
     {
          int max = ar[i];
          int w = i;
          int count = i;
          // Определяем максимум из оставшихся
          for (int j = i; j < k; j++) max = max > ar[j] ? max : ar[j];
          // Находим индекс максимального
          while (ar[w] != max) w++;
          // меняем местами
          count = ar[i];
          ar[i] = ar[w];
          ar[w] = count;
     }
     return ar;
}
int[] array = Ordering(arra);
Console.WriteLine(String.Join(", ", array));






























