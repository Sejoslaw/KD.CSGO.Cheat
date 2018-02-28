using KD.CSGO.Logic;
using KD.CSGO.Logic.Connections;
using System;
using System.Windows.Forms;

namespace KD.CSGOCheat
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(new CsgoCheatLogic(new CsgoConnector())));
        }
    }
}