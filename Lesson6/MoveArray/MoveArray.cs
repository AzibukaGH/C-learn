


// int[,] pic = new int[,]
// {
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
//  {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };

// void PrinIm(int[,] ima)
// {
//      for (int i = 0; i < ima.GetLength(0); i++)
//      {
//           for (int j = 0; j < ima.GetLength(1); j++)
//           {
//                if (ima[i, j] == 0)
//                {
//                     Console.Write("  ");
//                }
//                else Console.Write("++");
//           }
//           Console.WriteLine("");
//      }
// }

// void FillIm(int row, int col)
// {
//      if (pic[row, col] == 0)
//      {

//           pic[row, col] = 1;
//           FillIm(row - 1, col);
//           FillIm(row, col - 1);
//           FillIm(row + 1, col);
//           FillIm(row, col + 1);
//      }
// }
// PrinIm(pic);
// FillIm(13, 13);
// PrinIm(pic);
// int[,] gif(int[,] giff)
// {
//      for (int j = 0; j < giff.GetLength(0); j++) //line
//      {
//           int c = giff[j,0];
//           int k = 222;
//           for (int i = 1; i < giff.GetLength(1) - 1; i += 2)
//           {
//                k = giff[j,i];
//                giff[j,i] = c;
//                c = giff[j,i + 1];
//                giff[j,i + 1] = k;
//           }
//           giff[j,0] = c;
          
//      }
//      return giff;
// }
// PrinIm(gif(pic));


// void PrintMoveAr(int[,] arrr)
// {
//      int[,] mar = gif(arrr);
//      PrinIm(mar);
     
// }
// void MoveLive(int[,] arml){
//           for (int i = 0; i < 125; i++)
//           {
//           PrintMoveAr(arml);  
//                for(int u = 0; u<10; u++){
//                } 
//           }
// }

// MoveLive(pic);






// // class Program
// // {
// //     static void Main(string[] args)
// //     {
// //         int num = 0; 
// //         // устанавливаем метод обратного вызова
// //         TimerCallback tm = new TimerCallback(Count);
// //         // создаем таймер
// //         Timer timer = new Timer(tm, num, 0, 2000);

// //         Console.ReadLine();
// //     }
// //     public static void Count(object obj)
// //     {
// //         int x = (int)obj;
// //         for (int i = 1; i < 9; i++, x++)
// //         {
// //             Console.WriteLine($"{x * i}");      
// //         }
// //     }
// // }

// // int[] arra = new int[] 
// // { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
// // // Console.WriteLine(String.Join(", ", arra));

// // int[] MoveArr(int[] arr)
// // {
// //      int c = arr[0];
// //      int k = 222;
// //      for (int i = 1; i < arr.Length - 1; i += 2)
// //      {
// //           k = arr[i];
// //           arr[i] = c;
// //           c = arr[i + 1];
// //           arr[i + 1] = k;
// //      }
// //      arr[0] = c;
// //      return arr;
// // }

// // void PrintMoveAr(int[] arrr)
// // {
// //      int[] mar = MoveArr(arrr);
// //      Console.WriteLine(String.Join(", ", mar));
     
// // }

// // void MoveLive(int[] arml){
// //      for (int i = 0; i < 100; i++)
// //      {
// //        PrintMoveAr(arml);   
// //      }
// // }
// // Console.WriteLine(String.Join(", ", arra));
// // MoveLive(arra);



// // if (){}
// // Console.WriteLine(String.Join(", ", mar1));
// // Console.WriteLine(String.Join(", ", mar2));
// // Console.WriteLine(String.Join(", ", mar3));
// // Console.WriteLine(String.Join(", ", mac));
// // Console.WriteLine(String.Join(", ", mar5));
// // Console.WriteLine(String.Join(", ", mar6));