namespace _18
{
    internal class Program
    {
        static int putere(int a, int x)
        {
            int rezultat = 1;
            for (int i = 1; i <= x; i++)
                rezultat = rezultat * a;
            return rezultat;    
        }
        static int polinom(int n,int[]v, int valoare)
        {
            int rezultat = 0;
            for(int i = 0; i < n; i++) 
                rezultat =rezultat+ v[i] * putere(valoare, i);
            return rezultat;

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x= int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            Console.WriteLine(polinom(n,v,x));
         
        }
    }
}
