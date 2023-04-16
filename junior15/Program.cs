string password = "1234";
string secretMessage = "Тайное сообщение";

int attempt = 3;

for (int i = 0; i < attempt; i++)
{
    Console.Write("Введите пароль: ");
    string passwordEntry = Console.ReadLine();

    if (passwordEntry == password)
    {
        Console.WriteLine(secretMessage);
        break;
    }
    else
    {
        Console.WriteLine("Не верный пароль");
    }
}