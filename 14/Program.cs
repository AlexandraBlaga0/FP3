namespace _14
{
    internal class Program
    {
        static void sortare(int n, int[] v)
        {
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (v[i] != 0)
                {
                    v[j] = v[i];
                    j++;
                }
            }
            while (j < n)
            {
                v[j] = 0;
                j++;
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
            sortare(n, v);
        }
    }
}