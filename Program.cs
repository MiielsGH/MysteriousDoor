string secretCode = "1992";
string attempt = "";
while (attempt != secretCode)
{
    Console.Write("Enter the secret code: ");
    attempt = Console.ReadLine();

    if (attempt != secretCode)
    {
         Console.WriteLine("Incorrect code. Please try again.\n");
    }
}

Console.WriteLine("The door is unlocked, Congratulations!");
