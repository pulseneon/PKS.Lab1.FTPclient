using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKS.Lab1.FTPclient.CommandExecute
{
    partial class CommandExecute
    {
        public void Download(string[] args)
        {
            if (args.Length <= 1) return;
            var path = $"{_folder}/{args[1]}";

            string currentDir = Environment.CurrentDirectory;
            _client.DownloadFile($"{currentDir}\\{args[1]}", path);
        }
    }
}
