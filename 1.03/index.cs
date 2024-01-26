using System;

class Program
{
    static void Main()
    {
        int a = 7;
        int b = a - 6;
        int[]v = new int [7];

       while(b<a){
        v[b] = b + a;
        System.Console.WriteLine($"v[{b}] = {v[b]}");
        b = b + 2;
       }
      
    }
}
