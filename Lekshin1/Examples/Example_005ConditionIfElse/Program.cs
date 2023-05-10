Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
   Console.WriteLine("О это Маша");
   Console.Write(username);
}
else
{
   Console.WriteLine("Привет", username);
   Console.Write(username);
}