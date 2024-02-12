using FluentFTP;
using FluentFTP.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKS.Lab1.FTPclient.CommandExecute
{
    partial class CommandExecute
    {
        private FtpClient _client;
        private string _folder;

        public CommandExecute(FtpClient client)
        {
            _client = client;
            _folder = "";
        }
    }
}
