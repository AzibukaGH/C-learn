// // Задача 34: Задайте массив заполненный случайными 
// // положительными трёхзначными числами. Напишите программу,
// //  которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

Console.WriteLine("Hello");

int[] FillAr()
{
     int[] arra = new int[8];
     for (int i = 0; i < arra.Length; i++)
     {
          arra[i] = new Random().Next(100, 999);
     }
     return arra;
}
int[] array1 = FillAr();

void OddNum(int[] arr)
{
     int n = arr.Length;
     int oddn = 0;
     for (int i = 0; i < n; i++)
     {
          if (arr[i] % 2 == 0)
               oddn++;
     }
     Console.WriteLine(oddn);
}
OddNum(array1);

Console.WriteLine(String.Join(", ", array1));
