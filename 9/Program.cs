namespace _9
{
    internal class Program
    {
        static void rotire(int n, int[] v,int k)
        {
            
            while (k > 0)
            {
                int a = v[0];
                for (int i = 0; i < n - 1; i++)
                    v[i] = v[i + 1];
                v[n - 1] = a;
                k--;
            }
            for (int i = 0; i < n; i++)
                    Console.WriteLine(v[i]);

            
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            rotire(n, v,k);
        }
    }
}
