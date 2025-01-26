namespace _4
{
    internal class Program
    {
        static void pozitii(int n, int[] v)
        {
            int mini = v[0], maxi = v[0], aparitiiMaxi = 1, aparitiiMini = 1;
            for (int i = 0; i < n; i++)
            {
                if (v[i] > maxi)
                {
                    maxi = v[i];
                    aparitiiMaxi = i;
                }
                else if (v[i] == maxi)
                    aparitiiMaxi++;
                else if (v[i] < mini)
                {
                    mini = v[i];
                    aparitiiMini = i;
                }
                else if (v[i] == mini)
                    aparitiiMini++;
            }
            Console.WriteLine($"Maximul {maxi} apare de {aparitiiMaxi} iar minimul {mini} apare de {aparitiiMini} ");
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            pozitii(n, v);
        }
    }
}
