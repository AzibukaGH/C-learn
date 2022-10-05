void FindTask()
{
     Console.Write(" Print task number (41, 43) = ");
     int taskNumber = int.Parse(Console.ReadLine());
     LaunchProgram(taskNumber);
}



void Task41()
{
     Console.WriteLine("Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
     Console.Write("how many numbers do you watn to taransmit? NUMBERS =  ");
     int num = int.Parse(Console.ReadLine());
     int[] array = new int[num];
     int[] FillArray(int[] arr)
     {
          for (int i = 0; i < arr.Length; i++)
          {
               Console.Write($"Print num ({i + 1}) = ");
               arr[i] = int.Parse(Console.ReadLine());
          }
          return arr;
     }
     void PrintArray(int[] ar)
     {

          Console.WriteLine(String.Join(", ", ar));

     }
     void NumBiggerZero(int[] arra)
     {
          int k = 0;
          for (int i = 0; i < arra.Length; i++)
          {
               k += arra[i] > 0 ? 1 : 0;
          }
          Console.WriteLine(k);
     }
     PrintArray(FillArray(array));
     NumBiggerZero(array);
}


void Task43()
{
     Console.WriteLine("Напишите программу, которая найдёт точку пересечения двух прямых");
     Console.Write(" b1 =  ");
     double b1 = double.Parse(Console.ReadLine());
     Console.Write(" k1 =  ");
     double k1 = double.Parse(Console.ReadLine());
     Console.Write(" b2 =  ");
     double b2 = double.Parse(Console.ReadLine());
     Console.Write(" k2 =  ");
     double k2 = double.Parse(Console.ReadLine());

     void FindXY(double b1, double k1, double b2, double k2)
     {
          if (k1 == k2) Console.WriteLine(" lines are parallel ");
          else
          {
               double x = (b2 - b1) / (k1 - k2);
               double y = k1 * x + b1;
               Console.WriteLine($"({x}, {y})");
          }
     }
     FindXY(b1, k1, b2, k2);
}
void LaunchProgram(int num)
{


      if (num == 41) Task41();
     else if (num == 43) Task43();
     else
     {
          Console.WriteLine("Try again");
          FindTask();
     }
}
FindTask();