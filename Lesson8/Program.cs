void FindTask()
{
     Console.Write(" Print task number (54, 56, 58, 60, 62) = ");
     int taskNumber = int.Parse(Console.ReadLine());
     LaunchProgram(taskNumber);
}
void Task54()
{
     Console.WriteLine("Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
     int[,] arra = new int[4, 8];

     int[,] FillArray(int[,] arra)
     {
          for (int i = 0; i < arra.GetLength(0); i++)
          {
               for (int j = 0; j < arra.GetLength(1); j++)
               {
                    arra[i, j] = new Random().Next(0, 100);
               }
          }
          return arra;
     }
     void PrintArray(int[,] ar)
     {
          for (int i = 0; i < arra.GetLength(0); i++)
          {
               for (int j = 0; j < arra.GetLength(1); j++)
               {
                    Console.Write($"{arra[i, j]} \t");
               }
               Console.WriteLine("");
          }

     }
     arra = FillArray(arra);
     PrintArray(arra);
     Console.WriteLine();

     int[,] SortArray(int[,] ar)
     {
          int lines = ar.GetLength(0);
          int colums = ar.GetLength(1);

          for (int j = 0; j < lines; j++)
          {
               for (int i = 0; i < colums; i++)
               {
                    int max = ar[j, i];
                    int w = i;
                    int count = i;
                    // Определяем максимум из оставшихся
                    for (int k = i; k < colums; k++) max = max > ar[j, k] ? max : ar[j, k];
                    // Находим индекс максимального
                    while (ar[j, w] != max) w++;
                    // меняем местами
                    count = ar[j, i];
                    ar[j, i] = ar[j, w];
                    ar[j, w] = count;
               }


          }
          Console.WriteLine();
          PrintArray(ar);
          return ar;
     }
     int[,] sortArray = SortArray(arra);
}
void Task56()
{
     Console.WriteLine("Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
     int[,] arra = new int[4, 8];

     int[,] FillArray(int[,] arra)
     {
          for (int i = 0; i < arra.GetLength(0); i++)
          {
               for (int j = 0; j < arra.GetLength(1); j++)
               {
                    arra[i, j] = new Random().Next(0, 10);
               }
          }
          return arra;
     }
     void PrintArray(int[,] ar)
     {
          for (int i = 0; i < ar.GetLength(0); i++)
          {
               for (int j = 0; j < ar.GetLength(1); j++)
               {
                    Console.Write($"{ar[i, j]} \t");
               }
               Console.WriteLine("");
          }

     }
     arra = FillArray(arra);
     PrintArray(arra);
     Console.WriteLine();

     int[] FindMinLineAr(int[,] arr)
     {
          int[] minOfLine = new int[arr.GetLength(0)];
          for (int i = 0; i < arra.GetLength(0); i++)
          {
               int sumLine = 0;
               for (int j = 0; j < arr.GetLength(1); j++)
               {
                    sumLine += arr[i, j];
               }
               minOfLine[i] = sumLine;
          }

          return minOfLine;
     }
     int[] array = FindMinLineAr(arra);
     // Console.WriteLine(string.Join(", ", array));

     int minOfArray(int[] arrray)
     {
          int minArr = 10000;
          for (int i = 0; i < array.GetLength(0); i++)
          {
               minArr = minArr > arrray[i] ? arrray[i] : minArr;
          }
          Console.WriteLine(minArr);
          return minArr;
     }
     minOfArray(array);
}
void Task58()
{
     Console.WriteLine("Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
     int[,] array1 = new int[2, 2];
     int[,] array2 = new int[2, 2];


     int[,] FillArray(int[,] arr)
     {
          for (int i = 0; i < arr.GetLength(0); i++)
          {
               for (int j = 0; j < arr.GetLength(1); j++)
               {
                    arr[i, j] = new Random().Next(0, 10);
               }
          }
          return arr;
     }
     void PrintArray(int[,] ar)
     {
          for (int i = 0; i < ar.GetLength(0); i++)
          {
               for (int j = 0; j < ar.GetLength(1); j++)
               {
                    Console.Write($"{ar[i, j]}  ");
                    // Console.Write(ar[i, j]);
               }
               Console.WriteLine("");
          }
     }
     array1 = FillArray(array1);
     PrintArray(array1);
     Console.WriteLine();
     array2 = FillArray(array2);
     PrintArray(array2);
     int[,] CompositionArray(int[,] arr1, int[,] arr2)
     {
          int lenghtHightAr = arr1.GetLength(1);
          int[,] arra1 = new int[lenghtHightAr, lenghtHightAr];
          for (int i = 0; i < lenghtHightAr; i++)
          {
               for (int j = 0; j < lenghtHightAr; j++)
               {
                    for (int jk = 0; jk < lenghtHightAr; jk++)
                    {
                         arra1[i, j] = arra1[i, j] + arr1[i, jk] * arr2[jk, j];
                    }
               }
          }

          Console.WriteLine();
          PrintArray(arra1);
          return arra1;
     }
     int[,] HadnAr(int[,] arr1, int[,] arr2)
     {
          int[,] arra1 = new int[2, 2];
          arra1[0, 0] = arr1[0, 0] * arr2[0, 0] + arr1[0, 1] * arr2[1, 0];
          arra1[0, 1] = arr1[0, 0] * arr2[0, 1] + arr1[0, 1] * arr2[1, 1];
          arra1[1, 0] = arr1[1, 0] * arr2[0, 0] + arr1[1, 1] * arr2[1, 0];
          arra1[1, 1] = arr1[1, 0] * arr2[0, 1] + arr1[1, 1] * arr2[1, 1];
          Console.WriteLine();
          Console.WriteLine("Проверочный результат");
          PrintArray(arra1);
          return arra1;
     }
     HadnAr(array1, array2);
     CompositionArray(array1, array2);

}
void Task60()
{
     Console.WriteLine("Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
     int colums = 2;
     int lines = 2;
     int rows = 2;
     int[,,] array1 = new int[rows, lines, colums];
     int[,,] FillAr(int[,,] arr)
     {
          for (int i = 0; i < rows; i++)
          {
               for (int j = 0; j < lines; j++)
               {
                    for (int k = 0; k < colums; k++)
                    {
                         void FillNum(int i)
                         {
                              int randomNum = new Random().Next(9);
                              int exeption = 0;
                              for (int dni = 0; dni < colums; dni++)
                              {
                                   for (int dnj = 0; dnj < colums; dnj++)
                                   {
                                        for (int dnk = 0; dnk < colums; dnk++)
                                        {
                                             if (randomNum == arr[dni, dnj, dnk]) exeption++;
                                        }
                                   }
                              }
                              if (exeption != 0) FillNum(i);
                              else arr[i, j, k] = randomNum;
                         }
                         FillNum(i);
                    }
               }
               Console.WriteLine();
          }

          return arr;
     }
     int[,,] arrayEnd = FillAr(array1);

     void PrintArray333(int[,,] ara)
     {
          for (int i = 0; i < colums; i++)
          {
               for (int j = 0; j < colums; j++)
               {
                    for (int k = 0; k < colums; k++)
                    {
                         Console.Write($"  {ara[i, j, k]} ({i},{j},{k})");
                    }
                    Console.WriteLine();
               }
          }
     }
     PrintArray333(arrayEnd);
    

}
void LaunchProgram(int num)
{

     if (num == 54) Task54();
     else if (num == 56) Task56();
     else if (num == 58) Task58();
     else if (num == 60) Task60();
     else
     {
          Console.WriteLine("Try again");
          FindTask();
     }
}
FindTask();

