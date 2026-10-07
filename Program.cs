string secretCode = "1992";
string attempt = "";

int tries = 3;

while (attempt != secretCode && tries > 0)
{
        tries--;

    Console.Write("Enter the secret code: ");
    attempt = Console.ReadLine();

if (attempt != secretCode)
    {
         Console.WriteLine("Incorrect code. Please try again.");
    }
}
if (tries == 0 && attempt != secretCode)
{
    Console.WriteLine("You have run out of attempts. The door remains locked.");
}
else
{
Console.WriteLine("The door is unlocked, Congratulations!");
}
