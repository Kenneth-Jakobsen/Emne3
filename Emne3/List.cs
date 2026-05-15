namespace Emne3;

public class List
{
    public void Run()
    {
        int[] numbers = { 5, 10, 32 };

        //Kan endre men ikke legge til
        numbers[0] = 100;
        
        List<string> navn = [];
        
        //Legge til
        navn.Add("John");
        navn.Add("Joe");
        
        //Slette
        navn.Remove("Joe");
        navn.RemoveAt(0);

        //Lese
        Console.WriteLine(navn.Count);
        
        //Finne første treff
        string funnet = navn.Find(n=> n=="John");
        Console.WriteLine(funnet);
        
        //Sjekke om verdien finnes
        bool finnes = navn.Contains("John");
    }
    
}