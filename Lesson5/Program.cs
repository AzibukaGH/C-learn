// // Задача 34: Задайте массив заполненный случайными 
// // положительными трёхзначными числами. Напишите программу,
// //  которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

// Console.WriteLine("Hello");

// int[] FillAr()
// {
//      int[] arra = new int[8];
//      for (int i = 0; i < arra.Length; i++)
//      {
//           arra[i] = new Random().Next(100, 999);
//      }
//      return arra;
// }
// int[] array1 = FillAr();

// void OddNum(int[] arr)
// {
//      int n = arr.Length;
//      int oddn = 0;
//      for (int i = 0; i < n; i++)
//      {
//           if (arr[i] % 2 == 0)
//                oddn++;
//      }
//      Console.WriteLine(oddn);
// }
// OddNum(array1);

// Console.WriteLine(String.Join(", ", array1));









// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.WriteLine("hi");
// int[] FillAr(){
//       int[] arra = new int[6];
//      for (int i = 0; i < arra.Length; i++)
//      {
//           arra[i] = new Random().Next(1, 100);
//      }
//      return arra;
// }
// int[] arrayy= FillAr();

// void SumOddIndexNum(int[] ar){
//   int sum = 0;
//   for (int i= 1; i<ar.Length; i= i+2){
//      sum = sum+ ar[i];
//   }  Console.WriteLine(sum); 
// }
// Console.WriteLine(String.Join(", ", arrayy));
// SumOddIndexNum(arrayy);








// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

// Console.WriteLine(" Start ");

// double[] FillAr()
// {
//      double[] ar = new double[5];
//      for (int i = 0; i < 5; i++)
//      {
//           double k = new Random().Next(80);
//           ar[i] = k + k / 10;
//      }
//      return ar;
// }
// double[] arra = FillAr();
// // Console.WriteLine(String.Join(", ", arra));
// Console.WriteLine(String.Join(" ", arra));
// double FindMax(double[] ar)
// {
//      double k = ar.Length;
//      double max = -1;
//      for (int i = 0; i < k; i++)
//      {
//           max = ar[i] > max ? ar[i] : max;
//      }
//      return max;
// }
// double FindMin(double[] ar)
// {
//      double k = ar.Length;
//      double min = 100;
//      for (int i = 0; i < k; i++)
//      {
//           min = ar[i] < min ? ar[i] : min;
//      }
//      return min;
// }
// void diff(double a, double i)
// {
//      Console.Write(a - i);
// }
// diff(FindMax(arra), FindMin(arra));




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



int[,] pic = new int[,]
{
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
 {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};






























// int[] GetArray(int size, int minValue, int maxValue)
// {
//      int[] res = new int[size];

//      for (int i = 0; i < size; i++)
//      {
//           res[i] = new Random().Next(minValue, maxValue + 1);
//      }
//      return res;
// }
// int[] PositiveAndNegativeSum(int[] array)
// {
//      int[] res = new int[2];

//      for (int i = 0; i < array.Length; i++)
//      {
//           if (array[i] > 0)
//           {
//                res[0] += array[i];
//           }
//           else
//           {
//                res[1] += array[i];
//           }

//      }

//      return res;
// }

// int[] myArray = GetArray(10, -100, 100);
// int[] result = PositiveAndNegativeSum(myArray);
// Console.WriteLine(String.Join(" ", myArray));
// Console.WriteLine(String.Join(" ", result));







