void PrintInterval(int m, int n)
  {
   int start = m;
   int end = n;
   if(m > n)
   {
    start = n;
    end = m;
   }
   for(int i = start; i <= end; i++)
   {
    Console.Write($"{i} ");
   }
  }
  PrintInterval(22, 9);
  
  Console.WriteLine();