namespace Lunghezza_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("Specifica la lunghezza dell'array");
            x = int.Parse(Console.ReadLine());
            int[] numList = new int[x];
            int i;
            int add = 0;
            for (i = 0; i < numList.Length; i++)
            {
                Console.WriteLine("inserisci un numero");
                numList[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < numList.Length; i++)
            {
                add += numList[i];
            }
            Console.WriteLine($"\nLa somma è: {add}\n");
            Console.WriteLine($"La media è: {add
                / x}");
            Console.ReadLine();
        }
    }
}
