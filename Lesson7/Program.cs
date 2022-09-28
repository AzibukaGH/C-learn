void FindTask()
{
     Console.Write(" Print task number (47, 50, 52) = ");
     int taskNumber = int.Parse(Console.ReadLine());
     LaunchProgram(taskNumber);
}

void Task47()
{
     Console.WriteLine("Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
     Console.Write(" m = ");
     int m = int.Parse(Console.ReadLine());
     Console.Write(" n = ");
     int n = int.Parse(Console.ReadLine());
     double[,] matrix = new double[m, n];
     void PrintArray(double[,] matr)
     {
          for (int i = 0; i < matr.GetLength(0); i++)
          {
               for (int j = 0; j < matr.GetLength(1); j++)
               {
                    Console.Write($"{matr[i, j]} ");
               }
               Console.WriteLine();
          }
     }
     void FillArray(double[,] matr)
     {
          for (int i = 0; i < matr.GetLength(0); i++)
          {
               for (int j = 0; j < matr.GetLength(1); j++)
               {
                    double doubleNum = new Random().Next(1, 10);
                    matr[i, j] = new Random().Next(-10, 10) + doubleNum / 10;
               }
          }
     }

     FillArray(matrix);

     PrintArray(matrix);
}



void Task50()
{
     Console.WriteLine("Напишите программу, которая на вход принимает число и генерирует случайный двумерный массив, и возвращает индексы этого элемента или же указание, что такого элемента нет.");
     Console.Write(" num = ");
     int num = int.Parse(Console.ReadLine());
     int n = new Random().Next(1, 10);
     int m = new Random().Next(2, 10);


     int[,] matrix = new int[m, n];
     void PrintArray(int[,] matr)
     {
          for (int i = 0; i < matr.GetLength(0); i++)
          {
               for (int j = 0; j < matr.GetLength(1); j++)
               {
                    Console.Write($"{matr[i, j]} ");
               }
               Console.WriteLine();
          }
     }
     void FillArray(int[,] matr)
     {
          for (int i = 0; i < matr.GetLength(0); i++)
          {
               for (int j = 0; j < matr.GetLength(1); j++)
               {
                    matr[i, j] = new Random().Next(0, 10);
               }
          }
     }

     FillArray(matrix);
     PrintArray(matrix);
     void FindNum(int[,] matr, int findNum)
     {
          String ss = "";
          for (int i = 0; i < matr.GetLength(0); i++)
          {
               for (int j = 0; j < matr.GetLength(1); j++)
               {
                    ss += findNum == matr[i, j] ? $"[{i},{j}] " : "";

               }

          }
          String sss = ss == "" ? "такого числа в массиве нет" : ss;
          Console.WriteLine(sss);
     }
     FindNum(matrix, num);
}


void Task52()
{
     Console.WriteLine("Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
     int n = new Random().Next(1, 10);
     int m = new Random().Next(1, 10);



     int[,] matrix = new int[m, n];
     void PrintArray(int[,] matr)
     {
          for (int i = 0; i < matr.GetLength(0); i++)
          {
               for (int j = 0; j < matr.GetLength(1); j++)
               {
                    Console.Write($"{matr[i, j]} ");
               }
               Console.WriteLine();
          }
     }
     void FillArray(int[,] matr)
     {
          for (int i = 0; i < matr.GetLength(0); i++)
          {
               for (int j = 0; j < matr.GetLength(1); j++)
               {
                    matr[i, j] = new Random().Next(0, 10);
               }
          }
     }

     FillArray(matrix);
     PrintArray(matrix);
     void FindNum(int[,] matr)
     {
          int[] arrayLine = new int[matr.GetLength(1)];
          double[] arrayLineDouble = new double[matr.GetLength(1)];

          for (int i = 0; i < matr.GetLength(0); i++)
          {
               for (int j = 0; j < matr.GetLength(1); j++)
               {
                    arrayLine[j] += matr[i, j];
                    arrayLineDouble[j] += matr[i, j];
                    if (i == matr.GetLength(0) - 1)
                    {

                         double rround = arrayLineDouble[j] / matr.GetLength(0);

                         arrayLineDouble[j] = Math.Round(rround, 1);
                         //используется мат формула, можно было обойтись и без нее,
                         //тогда бы код выглядел следующим образом:
                         //  arrayLineDouble[j] /= matr.GetLength(0);
                    }
               }

          }
          Console.WriteLine(String.Join(", ", arrayLine));
          
          Console.WriteLine(String.Join(", ", arrayLineDouble));
     }
     FindNum(matrix);
}

void LaunchProgram(int num)
{

     if (num == 47) Task47();
     else if (num == 50) Task50();
     else if (num == 52) Task52();
     else
     {
          Console.WriteLine("Try again");
          FindTask();
     }
}
FindTask();
