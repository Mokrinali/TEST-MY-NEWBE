// See https://aka.ms/new-console-template for more information
string secretWord = "giraffe";
string guess = "";
int guessCount = 0;
int guessLimit = 3;
bool outOfGuesses = false;
while (guess != secretWord && !outOfGuesses)
{
    if (guessCount < guessLimit)
    {


        Console.Write("Enter guess: ");
        guess = Console.ReadLine();
        guessCount++;
    }
    else
    {
        outOfGuesses = true;
    }

}
if (outOfGuesses)
{
    Console.Write("You Loos !");
}
else
{
    Console.Write("You Win !");
}

Console.ReadLine();
