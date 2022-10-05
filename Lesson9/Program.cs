






void FindTask()
{
     Console.Write(" Print task number (66, 68) = ");
     int taskNumber = int.Parse(Console.ReadLine());
     LaunchProgram(taskNumber);
}

void Task66()
{
     Console.WriteLine("Min =");
     int m = int.Parse(Console.ReadLine());
     Console.WriteLine("Max =");
     int n = int.Parse(Console.ReadLine());
     int min = m;
     int max = n;
     void FindSum(int min, int max)
     {
          for (int i = min + 1; i < max + 1; i++)
          {
               min += i;
          }
          Console.WriteLine("Проверка");
          Console.WriteLine(min);

     }
     FindSum(min, max);

     int FindSumRek(int m, int n)
     {
          if (m == n) return m;
          return (m + FindSumRek(m + 1, n));
     }
     Console.WriteLine(FindSumRek(m, n));
}
void Task68() { 
Console.WriteLine("Min =");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Max =");
int n = int.Parse(Console.ReadLine());

int AkKermanFunc (int m, int n){
     if (m==0) return n+1;
     else if (m>0 & n==0) return AkKermanFunc(m-1, 1);
     return AkKermanFunc(m-1, AkKermanFunc(m,n-1));
}
Console.WriteLine(AkKermanFunc(m,n));
}

void LaunchProgram(int num)
{


      if (num == 66) Task66();
     else if (num == 68) Task68();
    
     else
     {
          Console.WriteLine("Try again");
          FindTask();
     }
}
FindTask();