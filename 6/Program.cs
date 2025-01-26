namespace _6
{
    internal class Program
    {
        static void stergere(int n, int[] v, int k)
        {
            for (int i = k; i < n - 1; i++)
                v[i] = v[i + 1];
            n = n - 1;
            for (int i = 0; i < n ; i++)
                Console.WriteLine(v[i]);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
           
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            stergere(n, v, k);
        }

    }
}
