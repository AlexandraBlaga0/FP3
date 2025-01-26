namespace _19
{
    internal class Program
    {
        static int aparitii(int n, int [] s, int m, int [] p)
        {
            int numar = 0;
            for(int i=0; i<=n-m; i++)
                    {
                bool gasire = true;
                for(int j=0; j<m; j++)
                {
                    if (s[i + j] != p[j])
                        gasire = false;
                }
                if (gasire==true)
                {
                    numar++;
                }
            }
            return numar;

        }
         
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] s = new int[n];

            int m = int.Parse(Console.ReadLine());
            int[] p = new int[m];

            for (int i = 0; i < n; i++)
                s[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
                p[i] = int.Parse(Console.ReadLine());


            Console.WriteLine($"Secventa apare de {aparitii(n,s,m,p)} ori");
        }
    }
}
