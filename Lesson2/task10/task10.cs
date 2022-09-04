
//  10 Напишите программу, которая принимает на вход
//  трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write(" Print num ");
int numb = int.Parse(Console.ReadLine());
numb = (numb/10)%10;
Console.Write(numb);