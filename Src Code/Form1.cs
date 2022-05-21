using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMD.Command;

namespace MemoryManagementBSODFix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string b = "It's Memory Management Fix... Enjoy to use this :D";
            MessageBox.Show(b, "Memory Management Fix", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            var x = key.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management", true);
            x.SetValue("FeatureSettingsOverride", "3", RegistryValueKind.DWord);
            x.SetValue("FeatureSettingsOverrideMask", "3", RegistryValueKind.DWord);
            Thread.Sleep(6000);
            MessageBox.Show("Fixing Memory Management BSOD is Completed", "Memory Management Fix", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Cmd_Command cmd = new Cmd_Command();
            cmd.CommandLine("shutdown /r /t 0");
            Environment.Exit(412);
        }
    }
}
