
// 4.Напишите программу, которая принимает на
//   вход три числа и выдаёт максимальное из этих чисел.
Console.Write(" NUMBER1 ");
int number1 = int.Parse(Console.ReadLine());
Console.Write(" NUMBER2 ");
int number2 = int.Parse(Console.ReadLine());
Console.Write(" NUMBER3 ");
int number3 = int.Parse(Console.ReadLine());
int res;
 res = number1 < number2 ? number2 : number1;
 res = res < number3 ? number3 : res;
 Console.WriteLine(res);




