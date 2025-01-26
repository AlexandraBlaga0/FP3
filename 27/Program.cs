namespace _27
{
    internal class Program
    {
        static void SelectionSort(int n, int[]v)
        {
            for (int i = 0; i < n - 1; i++)
            {
                int indexMin=i;
                for (int j = i + 1; j < n; j++)
                    if (v[j] < v[indexMin])
                    {
                        indexMin = j;
                    }
                if (indexMin!=i)
                {
                    int aux = v[i];
                    v[i] = v[indexMin];
                    v[indexMin] = aux;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dimensiune vector:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Elemente vector:");
            int[] v = new int[n];

            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("index vector");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Valoarea elementului de pe k este " + v[k]);

            SelectionSort(n, v);
            Console.WriteLine("Acum valoarea elementului de pe k este " + v[k]);


        }
    }
}
