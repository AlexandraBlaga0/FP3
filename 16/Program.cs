using System.Dynamic;

namespace _16
{
    internal class Program
    {
        static int cmmdc(int a, int b)
        { while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
                return a;
        }

        static int cmmdcElemente(int n, int []v)
          {
            int cmmdcCurent = v[0];
            for(int i = 1; i < n; i++)
            {
                cmmdcCurent = cmmdc(v[i], cmmdcCurent);
            }
            return cmmdcCurent;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            Console.WriteLine($"CMMDC este {cmmdcElemente(n,v)}");
        }
    }
}
