int CalculateSumm(int m, int n)
  {
   int start = m;
   int end = n;
   if(m > n)
   {
    start = n;
    end = m;
   }
   return (end + start)*(end - start + 1)/2; // по формуле суммы членов арифметической прогрессии
  }
  
  Console.WriteLine(CalculateSumm(1, 15));
 
