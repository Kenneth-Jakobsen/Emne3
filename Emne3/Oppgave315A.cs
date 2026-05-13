namespace Emne3;

public class Oppgave315A
{
    public void Run()
    {
        Console.WriteLine("Guess the number");
      
        var random = new Random();
        int number = random.Next(1,100);
        bool isCorrect = false;


        while (isCorrect != true )
        {
            isCorrect = IsCorrect(number, isCorrect);
        }
        
    }

    private  bool IsCorrect(int number, bool isCorrect)
    {
        string? input = Console.ReadLine();
        int guessedNumber = int.Parse(input);
        if (guessedNumber>number)
        {
            Console.WriteLine("The number is too high");
        }
        else if (guessedNumber < number)
        {
            Console.WriteLine("The number is too low");
        }
        else
        {
            Console.WriteLine("You guessed the number!");
            isCorrect = true;
        }

        return isCorrect;
    }
}