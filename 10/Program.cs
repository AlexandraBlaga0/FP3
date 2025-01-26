namespace _10
{
    internal class Program
    {
        static int  CautareBinara(int n, int [] v, int k)
        {
            int st= 0;
            int dr = n - 1;
            while(st<dr)
            {
               int mij=(st+dr)/2;
                if (v[mij] == k)
                    return mij;
                else if (v[mij] < k)
                    st = mij + 1;
                else dr = mij - 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            Console.WriteLine(CautareBinara(n,v,k));
        }
    }
}
