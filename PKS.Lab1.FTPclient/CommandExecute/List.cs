using FluentFTP.Exceptions;
using FluentFTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKS.Lab1.FTPclient.CommandExecute
{
    partial class CommandExecute
    {
        public void List()
        {
            try
            {
                foreach (FtpListItem item in _client.GetListing(_folder))
                {
                    if (item.Type == FtpObjectType.File)
                    {
                        Console.WriteLine($" {item.FullName,-30} время изменения: {item.Modified,-30} размер {item.Size} байт");
                    }
                    if (item.Type == FtpObjectType.Directory)
                    {
                        Console.WriteLine($" {item.FullName,-30} время изменения: {item.Modified,-30} директория");
                    }
                }
            }
            catch (FtpCommandException ex)
            {
                Console.WriteLine("Ошибка открытия папки. Возвращаем корневую директорию");
                _folder = string.Empty;
            }
        }
    }
}
