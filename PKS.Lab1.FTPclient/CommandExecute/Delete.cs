using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKS.Lab1.FTPclient.CommandExecute
{
    partial class CommandExecute
    {
        public void Delete(string[] args)
        {
            if (args.Length <= 1) return;
            var path = $"{_folder}/{args[1]}";

            if (_client.DirectoryExists(path))
                _client.DeleteDirectory(path);

            if  (_client.FileExists(path))
                _client.DeleteFile(path);
        }
    }
}
