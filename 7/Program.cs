namespace _7
{
    internal class Program
    {
        static void inversare(int n, int[] v)
        {
            for (int i = 0; i < n/2; i++)
            {
                int aux = v[i];
                v[i] = v[n - 1 - i];
                    v[n - 1 - i] = aux;
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
            inversare(n, v);
        }

    }
}
