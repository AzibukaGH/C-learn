﻿// 8.Напишите программу, которая на вход принимает число
//  (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write(" nubmber ");
int number = int.Parse(Console.ReadLine());
for (int i = 2; i<= number; i= i+2){
     Console.Write($"{i}, ");
}






