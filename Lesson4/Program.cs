// 25
// Console.WriteLine("Hello, World! Print num: ");
// int num = int.Parse(Console.ReadLine());

// Console.WriteLine("Print level: ");
// int level = int.Parse(Console.ReadLine());

// double degree (int n, int l) {

//      return Math.Pow(n,l);
// }
// Console.Write(degree(num, level));

// 27.
// Console.Write("num: ");
// int num = int.Parse(Console.ReadLine());
// num = Math.Abs(num);
// int qual(int n)
// {
//      int q = 1;
//      int count = 0;
//      while (n > 9)
//      {
//           count = count + n % 10;
//           n = n / 10;
//           q++;
//      }
//      count = count + n;
//      return count;
// }
// Console.Write(qual(num));

// 29
// Console.WriteLine("Print N: ");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine("Print min of array: ");
// int min = int.Parse(Console.ReadLine());
// Console.WriteLine("Print max of array: ");
// int max = int.Parse(Console.ReadLine());

// int[] array = new int[n];

// void FillArray (int[] ar){
//      int n = ar.Length;
//      int i = 0;
// while(i<n) {
//      array[i]= new Random().Next(min, max);
//      i++;
// }
// }

// void PrintArray (int[] arr ){
//      int k = arr.Length;
//      int j =0;
//      while (j+1<k){
//           Console.Write($"{arr[j]}, ");
//           j++;
//      }
//      Console.Write(arr[j]);
// }
// FillArray(array);
// PrintArray(array);


Console.WriteLine("Print height: ");
int height = int.Parse(Console.ReadLine());
int star = 1;
int spase = 2;
int width = height;
void triangle (){
     while (star<height){
          int count = 0;
          while (count < width){
               if (count< (width-star)/2 | count >= width - (width-star)/2)
               Console.Write(" ");
               else Console.Write("*");
               count=count+1;
          }
          Console.WriteLine("");
          star++;
     }
}
triangle();
