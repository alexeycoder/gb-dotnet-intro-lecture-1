Console.Write("Введите имя пользователя: ");
string? userName = Console.ReadLine();

if (string.IsNullOrEmpty(userName))
{
	Console.WriteLine("Имя не введено!");
	return;
}

if (userName.ToLowerInvariant() == "маша")
{
	Console.WriteLine("Ура, это же Маша!");
}
else
{
	Console.Write("Привет, ");
	Console.WriteLine(userName);
}