namespace _2
{
    internal class Program
    {
        static int pozitia(int n, int[]v, int k)
        {
            for (int i = 0; i < n; i++)
                if (v[i] == k)
                    return i;
            return -1;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            Console.WriteLine(pozitia(n,v,k));
        }
    }
}
