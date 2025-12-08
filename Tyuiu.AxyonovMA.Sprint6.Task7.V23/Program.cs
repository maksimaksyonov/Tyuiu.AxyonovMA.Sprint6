using System;
using System.Windows.Forms;

namespace Tyuiu.AxyonovMA.Sprint6.Task7.V23
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
