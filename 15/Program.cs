namespace _15
{
    internal class Program
    {
        static void eliminare(int n, int[] v)
        {
           for(int i=0; i<n-1; i++)
            {
                for (int j = i + 1; j < n; j++)
                    if (v[i] == v[j])
                    {
                        n--;
                        for (int k = j; k < n; k++)
                            v[k] = v[k + 1];
                    }

            }
            for (int i = 0; i < n; i++)
                Console.WriteLine(v[i]);

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            eliminare(n, v);
        }
    }
}