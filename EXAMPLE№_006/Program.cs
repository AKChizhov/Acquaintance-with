Console.Write("Ведите имя пользователя :  ");
string? userName = Console.ReadLine();

if (userName?.ToLower() == "федя")
{
    Console.WriteLine("Ура, это же Федя  !!");
}
else
{
    Console.WriteLine("Привет,  "+ userName);
}


