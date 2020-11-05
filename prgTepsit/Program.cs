using System;

namespace prgTepsit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il primo valore");
            int d1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo valore");
            int d2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci la dimensione in cui vuoi convertire l'immagine");
            int n = Convert.ToInt32(Console.ReadLine());
            int valoreConverito;
            valoreConverito = ((d1 * d2 * 3) / n);

            Console.WriteLine($"la dimensione dell'immagine è {valoreConverito}");
            Console.ReadLine();
            
        }
    }
}
