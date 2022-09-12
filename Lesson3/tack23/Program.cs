// Задача 23

// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

Console.Write(" print num  ");
int num = int.Parse(Console.ReadLine());
for (int i = 1; i<=num; i++){
     if (i<num)
     Console.Write($"{i*i*i}, ");
     else Console.Write($"{i*i*i}");
}