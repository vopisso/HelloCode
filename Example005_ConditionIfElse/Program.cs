Console.Write("Введите имя пользователя:  ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine();
    Console.Write("Ура!!! Это же МАША");
}
else
{
    Console.WriteLine();
    Console.Write("Привет, " + username + "!");
}