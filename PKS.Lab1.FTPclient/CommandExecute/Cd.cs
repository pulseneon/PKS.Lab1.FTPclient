using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKS.Lab1.FTPclient.CommandExecute
{
    partial class CommandExecute
    {
        public void Cd(string[] args)
        {
            if (args.Length <= 1)
            {
                return;
            }

            if (args[1].Equals(".."))
            {
                var parts = _folder.Split('/');
                if (parts.Length <= 1)
                {
                    _folder = string.Empty;
                }
                else
                {
                    _folder = string.Join('/', parts.SkipLast(1));
                }
            }

            else
            {
                _folder += "/" + args[1];
            }
        }
    }
}
