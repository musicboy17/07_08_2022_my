// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "маша")
{
   Console.WriteLine("УРА! Это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}