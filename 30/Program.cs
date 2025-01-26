namespace _30
{
    internal class Program
    {
        static void SelectionSort(int n, int[]E, int[]W)
        {
            for(int i=0; i<n-1; i++)
            {
               int  indexMin = i;
                for(int j=i+1; j<n; j++)
                {
                    if (E[j] < E[indexMin])
                        indexMin = j;
                    else if (E[j] == E[indexMin] && W[j] > W[indexMin])
                        indexMin = j;
                }
                if (indexMin != i)
                {
                   int aux = E[i];
                    E[i]= E[indexMin];
                    E[indexMin] = aux;
                    aux = W[i];
                    W[i] = W[indexMin];
                    W[indexMin] = aux;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dimensiune vectori :");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Elemente E:");
            int[] E = new int[n];
            for (int i = 0; i < n; i++)
                E[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Elemente W:");
            int[] W = new int[n];
            for (int i = 0; i < n; i++)
                W[i] = int.Parse(Console.ReadLine());

            
            SelectionSort(n, E, W);

            for (int i = 0; i < n; i++)
                Console.WriteLine($"Valoare E: {E[i]}, Valoare W: {W[i]}");

        }
    }
}
