namespace Algoritmo_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                string[] listanomi = { "Flavio", "Giuseppe", "Sara", "chiara", "lorenzo" };
                string nome;
                int i;
                bool verifica = false;

                Console.WriteLine("Inserire il nome da trovare");
                nome = Console.ReadLine();

                for (i = 0; i < listanomi.Length; i++)
                {
                    if (listanomi[i] == nome)
                    {
                        Console.WriteLine("Il nome è presente nella lista");
                        verifica = true;
                    }

                }
                if (verifica == false)
                {
                    Console.WriteLine("Il nome non è presente nella lista");
                }

                Console.ReadLine();
            }

        }
    }
}
