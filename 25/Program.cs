using System.Runtime.Intrinsics;

namespace _25
{
    internal class Program
    {
        static void interclasare (int n, int[]v1, int m, int []v2)
        {
            int[] vector = new int[n + m];
            int i= 0, j=0, k=0;
            while(i<n && j<m)
            {
                if (v1[i] > v2[j])
                {
                    vector[k] = v2[j];
                    k++;
                    j++;
                }
                else
                {
                    vector[k] = v1[i];
                    k++;
                    i++;
                }
            }

            while (i < n)
            {
            vector[k] = v1[i];
            k++;
            i++;
                }

            while (j < m)
            {
                vector[k] = v2[j];
                k++;
                j++;
            }
            for (i = 0; i < n + m; i++)
                Console.WriteLine (vector[i]);

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

            interclasare(n, v1, m, v2);

        }
    }
}
