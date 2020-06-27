using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProvaTreino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
/// <summary>
/// Adicionar/Remover entradas do windows startup
/// </summary>
/// <param name="AppName">Nome da aplicação.</param>
/// <param name="enable">habilitar/desabilitar a entrada</param>
private void SetStartup(string AppName, bool enable)
{
    string runKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

    Microsoft.Win32.RegistryKey startupKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(runKey);
   
    if (enable)
    {
        if (startupKey.GetValue(AppName) == null)
        {
            startupKey.Close();
            startupKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(runKey, true);
            // Add startup reg key
            startupKey.SetValue(AppName, Application.ExecutablePath.ToString());
            startupKey.Close();
        }
    }
    else
    {
        // remove startup
        startupKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(runKey, true);
        startupKey.DeleteValue(AppName, false);
        startupKey.Close();
    }
}
    }
}
