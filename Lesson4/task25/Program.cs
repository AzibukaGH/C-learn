// 25 Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
Console.WriteLine("Hello, World! Print num: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Print level: ");
int level = int.Parse(Console.ReadLine());

double degree (int n, int l) {

     return Math.Pow(n,l);
}
Console.Write(degree(num, level));

