
// 2.Напишите программу, которая на вход 
// принимает два числа и выдаёт,
//  какое число большее, а какое меньшее.

Console.Write(" NUMBER1 ");
int number1 = int.Parse(Console.ReadLine());
Console.Write(" NUMBER2 ");
int number2 = int.Parse(Console.ReadLine());
int res;
res = number1 < number2 ? number2 : number1;
Console.WriteLine($"max = {res}");

