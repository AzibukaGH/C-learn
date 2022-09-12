// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом. Строки и массивы использовать нельзя!

 Console.Write(" print num: ");
int num = int.Parse(Console.ReadLine());
if (num <= 9999 | 100000 <= num) Console.Write("incorrect num ! ! ! ");
else if (num / 10000 == num % 10 & num / 1000 % 10 == num / 10 % 10)
     Console.Write(" yes ");
else Console.Write(" no ");

