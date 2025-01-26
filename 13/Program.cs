namespace _13
{
    internal class Program
    {
        static void InsertionSort(int n, int[] v)
        {
            //ca elementele sa fie crescatoare
            for (int i = 0; i < n; i++)
            {
                int curent = v[i];
                int j = i - 1;
                while(j>=0 && v[j] > curent)
                {
                    v[j + 1] = v[j];
                    j--;
                }
                v[j+1] = curent;
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
                InsertionSort(n, v);
        }
    }
}
