namespace _21
{
    internal class Program
    {
        static void ordine(int n, int m, string[] a, string[] b)
        {
            int c;
            int primul=-1, alDoilea=-1;
            if (m < n)
                c = m;
            else

                c = n;

            for (int i = 0; i < c; i++)
            {
                if (a[i].CompareTo(b[i]) < 0)
                {
                    primul = 1;
                    alDoilea = 2;
                    break;
                }
                if (a[i].CompareTo(b[i]) > 0)
                {
                    primul = 2;
                    alDoilea = 1;
                    break;
                }
            }
            if (primul == 1)
            {
                Console.WriteLine("primul este:");
                for (int i = 0; i < n; i++)
                    Console.WriteLine(a[i]);
                Console.WriteLine("al doilea este:");
                for (int i = 0; i < m; i++)
                    Console.WriteLine(b[i]);
            }
            else if (primul == 2) 

            {
                Console.WriteLine("primul este:");
                for (int i = 0; i < m; i++)
                    Console.WriteLine(b[i]);
                Console.WriteLine("al doilea este:");
                for (int i = 0; i < n; i++)
                    Console.WriteLine(a[i]);
            }
        }

            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                string[] v1 = new string[n];

                int m = int.Parse(Console.ReadLine());
                string[] v2 = new string[m];

                for (int i = 0; i < n; i++)
                    v1[i] = Console.ReadLine();

                for (int i = 0; i < m; i++)
                    v2[i] = Console.ReadLine();

                ordine(n, m, v1, v2);
            }
        
    }
}
