namespace _3
{
    internal class Program
    {
        static void pozitii(int n, int[] v)
        {
            int mini = v[0], maxi = v[0], pozitieMaxi = 0, pozitieMini = 0, localMaxi, localMini, pozitieLocalMini, pozitieLocalMaxi;
            for (int i = 0; i < n - 1; i = i+2)
            {
                if (v[i]< v[i+1])
                {
                    localMini = v[i];
                    localMaxi = v[i+1];
                    pozitieLocalMaxi =i+1;
                    pozitieLocalMini = i;
                }
                else
                {
                    localMaxi = v[i];
                    localMini = v[i + 1];
                    pozitieLocalMaxi = i ;
                    pozitieLocalMini = i+1;
                }
                if (localMini < mini)
                {
                    mini = localMini;
                    pozitieMini = pozitieLocalMini;
                }
                if (localMaxi>maxi)
                {
                    maxi = localMaxi;
                    pozitieMaxi = pozitieLocalMaxi;
                }
            }
            if (n%2==1)
            {
                if (v[n-1]<mini)
                {
                    mini =v[n-1];
                    pozitieMini =n-1;
                }
                if (v[n - 1] > maxi)
                {
                    maxi = v[n - 1];
                    pozitieMaxi = n - 1;
                }
            }
            Console.WriteLine($" Maximul este {maxi} pe pozitia {pozitieMaxi} iar minimul este {mini} pe pozitia {pozitieMini}");
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
