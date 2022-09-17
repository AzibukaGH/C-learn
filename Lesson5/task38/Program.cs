
// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

Console.WriteLine(" Start ");

double[] FillAr()
{
     double[] ar = new double[5];
     for (int i = 0; i < 5; i++)
     {
          double k = new Random().Next(80);
          ar[i] = k + k / 10;
     }
     return ar;
}
double[] arra = FillAr();
// Console.WriteLine(String.Join(", ", arra));
Console.WriteLine(String.Join(" ", arra));
double FindMax(double[] ar)
{
     double k = ar.Length;
     double max = -1;
     for (int i = 0; i < k; i++)
     {
          max = ar[i] > max ? ar[i] : max;
     }
     return max;
}
double FindMin(double[] ar)
{
     double k = ar.Length;
     double min = 100;
     for (int i = 0; i < k; i++)
     {
          min = ar[i] < min ? ar[i] : min;
     }
     return min;
}
void diff(double a, double i)
{
     Console.Write(a - i);
}
diff(FindMax(arra), FindMin(arra));



