Console.Write("Enter your username: ");
string username = Console.ReadLine();

if (username.ToLower == "Masha")
{
    Console.Write("Hey! This is Masha!");
}
else
{
    Console.Write ("Hey, ");
    Console.WriteLine(username);
}