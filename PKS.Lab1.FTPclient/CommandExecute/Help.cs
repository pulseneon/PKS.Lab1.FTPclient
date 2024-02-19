using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKS.Lab1.FTPclient.CommandExecute
{
    partial class CommandExecute
    {
        public void Help()
        {
            Console.WriteLine(" help - помощь");
            Console.WriteLine(" disconnect - прервать соединение");
            Console.WriteLine(" cd - измненить директорию (cd .. - назад)");
            Console.WriteLine(" ls - список файлов директории");
            Console.WriteLine(" delete - удалить файл");
            Console.WriteLine(" move - переименовать");
            Console.WriteLine(" mkdir - создать директорию");
            Console.WriteLine(" download - скачать файл");
            Console.WriteLine(" upload - загрузить файл");
        }
    }
}
