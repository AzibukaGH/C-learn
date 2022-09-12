// See https://aka.ms/new-console-template for more information
// 19
//  Console.Write(" print num: ");
// int num = int.Parse(Console.ReadLine());
// if (num <= 9999 | 100000 <= num) Console.Write("incorrect num ! ! ! ");
// else if (num / 10000 == num % 10 & num / 1000 % 10 == num / 10 % 10)
//      Console.Write(" yes ");
// else Console.Write(" no ");

// 21.
// Console.Write("x1 ");
// int x1 = int.Parse(Console.ReadLine());
// Console.Write("y1 ");
// int y1 = int.Parse(Console.ReadLine());
// Console.Write("z1 ");
// int z1 = int.Parse(Console.ReadLine());
// Console.Write("x2 ");
// int x2 = int.Parse(Console.ReadLine());
// Console.Write("y2 ");
// int y2 = int.Parse(Console.ReadLine());
// Console.Write("z2 ");
// int z2 = int.Parse(Console.ReadLine());

// int diff(int n1, int n2)
// {
//      return n1 - n2;
// }

// int pow(int n1)
// {
//      return n1 * n1;
// }

// int sum(int s1, int s2, int s3)
// {
//      return s1 + s2 + s3;
// }

// double sqrt(int sq)
// {
//      return Math.Sqrt(sq);
// }
// Console.Write(sqrt(sum(pow(diff(x1, x2)), pow(diff(y1, y2)), pow(diff(z1, z2)))));


Console.Write(" print num  ");
int num = int.Parse(Console.ReadLine());
for (int i = 1; i<=num; i++){
     if (i<num)
     Console.Write($"{i*i*i}, ");
     else Console.Write($"{i*i*i}");
}