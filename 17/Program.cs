namespace _17
{
    internal class Program
    {
        static string ConversieInBaza ( int numar, int baza)
        {
            string conversie = "";
            string valori = "0123456789ABCDEF";
            while(numar > 0)
            { conversie = valori[numar % baza]+conversie;
            numar = numar / baza;
            }
            return conversie;
        }
        static void Main(string[] args)
        {
           int n=int.Parse(Console.ReadLine());
            int baza = int.Parse(Console.ReadLine());
            Console.WriteLine($"Numarul {n} din baza 10 este {ConversieInBaza(n, baza)} in baza {baza}");
        }
    }
}
