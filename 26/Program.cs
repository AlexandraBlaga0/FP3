using System.Dynamic;
using System.Numerics;

namespace _26
{
    internal class Program
    {
        static void adunare(int n, int[]nr1, int m, int []nr2)
        {
            int i = n - 1;
            int j = m - 1;
            int rest = 0;
            int lungime = Math.Max(n, m)+1;
            int[] v = new int[lungime];
            int k = 0;
            while (i >= 0 || j >= 0 )
            {
                if (i >= 0 && j >= 0)
                {
                    v[k] = (nr1[i] + nr2[j] + rest ) % 10 ;
                    rest = (nr1[i] + nr2[j] + rest) / 10;
                }
                else
                {
                    if (j < 0)
                    {
                        v[k] = nr1[i] + rest;
                        rest = (nr1[i] + rest) / 10;
                    }

                    else
                    { v[k] = nr2[j] + rest;
                        rest = (nr2[i] + rest) / 10;
                    }
                    }
                i--;
                j--;
                k++;
            }
            if (rest > 0)
            {
                v[k] = rest;
                k++;
            }
            for (i = k-1; i >=0; i--)
                Console.WriteLine(v[i]);


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dimensiune vector 1:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Elemente vector 1:");
            int[] v1 = new int[n];
            for (int i = 0; i < n; i++)
                v1[i] = int.Parse(Console.ReadLine());


            Console.WriteLine("Dimensiune vector 2:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Elemente vector 2:");
            int[] v2 = new int[m];
            for (int i = 0; i < m; i++)
                v2[i] = int.Parse(Console.ReadLine());
                
            Console.WriteLine("Rezultat:");
            adunare(n, v1, m, v2);

        }
    }
}
