namespace _1
{
    internal class Program
    {
        static void suma(int n, int[]v)
        {
            int suma = 0;
            for (int i = 0; i < n; i++)
                suma = suma + v[i];
            Console.WriteLine(suma);
        }
        static void Main(string[] args)
        {
           int n=int.Parse(Console.ReadLine());
            int[]v = new int[n];
            for (int i = 0;i < n; i++)
                v[i]=int.Parse(Console.ReadLine());
            suma(n, v);
        }
    }
}
