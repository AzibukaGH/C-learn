
// 27.  Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе.
Console.Write("num: ");
int num = int.Parse(Console.ReadLine());
num = Math.Abs(num);
int qual(int n)
{
     int q = 1;
     int count = 0;
     while (n > 9)
     {
          count = count + n % 10;
          n = n / 10;
          q++;
     }
     count = count + n;
     return count;
}
Console.Write(qual(num));


