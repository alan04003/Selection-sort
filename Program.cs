using System;
using System.Diagnostics; 
public class Example {
   static void Main(string[] args) {

      Random rnd = new Random();
	   int[] arr = new int[1000];
      for (int j = 0; j < 1000; j++)
		   {
			   arr[j]=(rnd.Next(1, 1000)); 
		   }
	
      int n = 1000;
    
      for (int i = 0; i < n; i++) {
         Console.Write(arr[i] + " ");
      }
       Stopwatch stop = Stopwatch.StartNew();
      stop.Start();
      int temp, smallest;
      for (int i = 0; i < n - 1; i++) {
         smallest = i;
         for (int j = i + 1; j < n; j++) {
            if (arr[j] < arr[smallest]) {
               smallest = j;
            }
         }
         temp = arr[smallest];
         arr[smallest] = arr[i];
         arr[i] = temp;
      }
        stop.Stop();

      Console.WriteLine();
      for (int i = 0; i < n; i++) {
         Console.Write(arr[i] + " ");
         Console.WriteLine(" ");
      }
      Console.WriteLine("Time = " + stop.ElapsedMilliseconds + " ms");
   }
}