using System;

class Program
{
    static void Main()
    {
        int a = 7;
        int b = a - 6;
        int[]v = new int [6];

       while(b<a){
        v[b] = a + b;
        Console.WriteLine(v[b]);
        b = b + 2;
       }
      
    }
}