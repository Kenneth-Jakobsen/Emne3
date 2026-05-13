namespace Emne3;

public class Person
{
     private readonly string _name;
     private readonly int _age;
     public static int _personCount = 0;

    public Person(string name, int age)
    {
        _name = name;
        _age = age;
        _personCount++;
    }
    
    


    public void PrintInfo()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Age: {_age}");
        Console.WriteLine($"Person count: {_personCount}");
    }
}