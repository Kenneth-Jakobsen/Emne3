namespace Emne3;

class Program
{
    public static void Main(string[] args)
    {
        List<string> navn = new List<string>();


        while (true)
        {
            Console.WriteLine("Dette er en kontakt Liste");
            Console.WriteLine("Skriv 1 til å legge til");
            Console.WriteLine("Skriv 2 til å slette");
            Console.WriteLine("Skriv 3 til å vise listen");
            Console.WriteLine("Skriv 4 til å søkte");
            Console.WriteLine("Skriv Q til å avslutte");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("Skriv navnet du vil legge til");
                string mittNavn = Console.ReadLine();
                navn.Add(mittNavn);
            }
            else if (input == "2")
            {
                navn.RemoveAt(0);
            }
            else if (input == "3")
            {
                Console.Clear();
                foreach (var VARIABLE in navn)
                {
                    Console.WriteLine($"{VARIABLE}");
                }
            }
            else if (input == "4")
            {
                Console.WriteLine("Søk etter: ");
                string query = Console.ReadLine();
                string found = navn.Find(n => n == query);
                var foundIndex = navn.IndexOf(found);
                Console.WriteLine($"{found} har index {foundIndex}");
            }
            else if (input == "Q")
            {
                break;
            }
        }
    }
}