namespace _12
{
    internal class Program
    {
        static void SelectionSort(int n, int[]v)
        {
            //ca elementele sa fie crescatoare
            for (int i = 0; i < n - 1; i++)
            {
                int indexMini = i;
                for (int j = i + 1; j < n; j++)
                    if (v[j] < v[indexMini])
                        indexMini = j;
                if (indexMini != i)
                {
                    int aux = v[i];
                    v[i] = v[indexMini];
                    v[indexMini] = aux;
                }
            }
            for(int i=0; i < n; i++)
                Console.WriteLine(v[i]);

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            SelectionSort(n, v);
        }
    }
}
