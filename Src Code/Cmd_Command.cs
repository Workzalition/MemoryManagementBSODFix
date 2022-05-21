using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Command
{
    class Cmd_Command
    {
        public void CommandLine(string cmd_command)
        {
            ProcessStartInfo ux = new ProcessStartInfo();
            ux.FileName = "cmd";
            ux.Arguments = $"/c {cmd_command}";
            ux.Verb = "runas";
            ux.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(ux);
        }
    }
}
