// 25 Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
Console.WriteLine("Hello, World! Print num: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Print level: ");
int level = int.Parse(Console.ReadLine());

int degree (int n, int l) {
     int k = n;
     while (l>1){
          n = n*k;
          l--;
     }
     return n;
}
Console.Write(degree(num, level));

