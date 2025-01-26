namespace _20
{
    internal class Program
    {
        static void rotire(int n, string[] v)
        {
            string a = v[0];
            for (int i = 0; i < n - 1; i++)
                v[i] = v[i + 1];
            v[n - 1] = a;
           
        }
        static int suprapuneri(int n, string[] s1, string[] s2)
        {
            int numar = 0;

            for (int i = 0; i < n; i++)
            { for (int j = 0; j < n; j++)
                    if (s1[j] == s2[j])
                        numar++;
                rotire(n,s1);
                
            }
            return numar;
        }

        static void Main(string[] args)
        {
            string[] s1 = Console.ReadLine().Split(' ');
            string[] s2 = Console.ReadLine().Split(' ');
            Console.WriteLine(suprapuneri(s1.Length, s1, s2));
          

        }
    }
}
