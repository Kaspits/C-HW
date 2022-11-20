Console.Write("Add your name: ");
string username = Console.ReadLine();

if (username.ToLower() == "masha") 
{
    Console.WriteLine("Yes, its MASHA!");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}