namespace _5
{
    internal class Program
    {
        static void inserare(int n, int[] v, int k, int e)
        {
            for (int i = n ; i >= k; i--)
                v[i] = v[i - 1];
            v[k] = e;
            n = n + 1;
            for(int i=0; i<n; i++)
                Console.WriteLine(v[i]);
        }
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int[] v = new int[n+1];
                for (int i = 0; i < n; i++)
                    v[i] = int.Parse(Console.ReadLine());
                inserare(n, v,k,e);
            }
       
    }
}
