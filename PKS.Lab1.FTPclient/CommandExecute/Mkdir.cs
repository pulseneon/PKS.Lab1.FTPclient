using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKS.Lab1.FTPclient.CommandExecute
{
    partial class CommandExecute
    {
        public void Mkdir(string[] args)
        {
            if (args.Length <= 1) return;
            var path = $"{_folder}/{args[1]}";

            _client.CreateDirectory(path);
        }
    }
}
