namespace _11
{
    internal class Program
    {
        static bool prim(int x)
        {
            if (x == 0) return false;
            if (x == 1) return false;
            for (int d = 2; d * d <= x; d++)
                if (x % d == 0)
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            for(int i=2; i<=n; i++)
                if (prim(i))
                    Console.WriteLine(i);

        }
    }
}
