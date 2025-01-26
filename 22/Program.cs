using System;

namespace _22
{
    internal class Program
    {
        static void intersectia(int n, int m, int[] a, int[] b)
        {
            for (int i = 0; i < n; i++)
            {
 
                bool ok= true;
                for (int k = 0; k < i; k++)
                {
                   
           
                    if (a[k] == a[i])
                    {
                        ok = false;
                        break;
                    }
                }

                if (ok)
                for (int j = 0; j < m; j++)
            
                    if (a[i] == b[j])
                    {
                        Console.WriteLine(a[i]); 
                        break; 
                    }
               
            }
        }

        static void reuniunea(int n, int m, int[] a, int[] b)
        {
            for (int i = 0; i < n; i++)
            {
                bool ok = true;

                Console.WriteLine(a[i]);
             for(int j = 0;j < m; j++)
            {
                bool ok = true;
                for (int i = 0; i < n; i++)
                    if (a[i] == b[j])
                        ok = false;
                if (ok)
                    Console.WriteLine(b[j]);
            }
        }
        

        static void Main(string[] args)
        {
            Console.WriteLine("Lungime vector 1:");
            int n = int.Parse(Console.ReadLine());
            int[] v1 = new int[n];

            Console.WriteLine("Elemente vector 1:");
            for (int i = 0; i < n; i++)
                v1[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Lungime vector 2:");
            int m = int.Parse(Console.ReadLine());
            int[] v2 = new int[m];

            Console.WriteLine("Elemente vector 2:");
            for (int i = 0; i < m; i++)
                v2[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("intersectia:");
            intersectia(n, m, v1, v2);

            Console.WriteLine("reuniunea:");
            reuniunea(n, m, v1, v2);
        }
    }
}
