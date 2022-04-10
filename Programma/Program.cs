Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "полина")
{
    Console.WriteLine("Вау, да это же Полина!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}