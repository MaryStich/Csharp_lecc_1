// Особое обращение к "любимчику"

Console.Write("UserName: ");
string username = Console.ReadLine();

if(username.ToLower() == "mary")
{
    Console.WriteLine("Ура! Это же Маша!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}

