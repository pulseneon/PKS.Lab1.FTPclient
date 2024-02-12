using FluentFTP;
using PKS.Lab1.FTPclient.CommandExecute;

// localhost user 12345

FtpClient client = Auth();
var ce = new CommandExecute(client);

while (true)
{
    Console.Write("ftp > ");

    var command = Console.ReadLine().Split(" ");
    switch (command[0])
    {
        case "help": ce.Help(); break;
        case "ls": ce.List(); break;
        case "cd": ce.Cd(command); break;
        case "delete": ce.Delete(command); break;
        case "move": ce.Move(command); break;
        case "mkdir": ce.Mkdir(command); break;
        case "download": ce.Download(command); break;
        case "upload": ce.Upload(command); break;
        case "disconnect": ce.Disconnect(); client = Auth(); ce = new CommandExecute(client); break;
        default: Console.WriteLine("Неизвестная команда"); break;
    }
}

static FtpClient Auth()
{
    var client = new FtpClient();

    while (true)
    {
        Console.Clear();
        Console.Write("Введите хост, логин и пароль\n\n> ");
        var conn = Console.ReadLine().Split(" ");

        if (conn != null && conn.Length == 3)
        {
            try
            {
                client = new FtpClient(conn[0], conn[1], conn[2]);
                client.Connect();
            }
            catch (AggregateException)
            {
                Console.WriteLine("Ошибка авторизации. Проверьте имя пользователя и пароль");
                Console.ReadLine();
                continue;
            }
            break;
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Пример: 123.123.123.123 kostya qwerty12345\n");
            Console.ReadLine();
        }
    }

    Console.WriteLine("Вы успешно авторизовались. Нажмите enter для продолжения.\n");
    Console.ReadLine();
    return client;
}