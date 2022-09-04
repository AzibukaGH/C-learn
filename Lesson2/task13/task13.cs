
//  13: Напишите программу, которая выводит третью цифру (справа налево)
//   заданного числа или сообщает, что третьей цифры нет.
Console.Write(" Print num ");
int number1 = int.Parse(Console.ReadLine());
if (number1 < 100) Console.Write(" третьей цифры нет ");
else Console.Write((number1/100)%10);







