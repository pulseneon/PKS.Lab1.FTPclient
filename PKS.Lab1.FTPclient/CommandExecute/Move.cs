using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKS.Lab1.FTPclient.CommandExecute
{
    partial class CommandExecute
    {
        public void Move(string[] args)
        {
            if (args.Length <= 2) return;

            var path = $"{_folder}/{args[1]}";

            _client.MoveFile(path, args[2]);
        }
    }
}
