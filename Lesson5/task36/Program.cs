
// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("hi");
int[] FillAr(){
      int[] arra = new int[6];
     for (int i = 0; i < arra.Length; i++)
     {
          arra[i] = new Random().Next(1, 100);
     }
     return arra;
}
int[] arrayy= FillAr();

void SumOddIndexNum(int[] ar){
  int sum = 0;
  for (int i= 1; i<ar.Length; i= i+2){
     sum = sum+ ar[i];
  }  Console.WriteLine(sum); 
}
Console.WriteLine(String.Join(", ", arrayy));
SumOddIndexNum(arrayy);








