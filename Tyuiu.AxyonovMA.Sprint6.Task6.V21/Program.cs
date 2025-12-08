using System;
using System.Windows.Forms;

namespace Tyuiu.AxyonovMA.Sprint6.Task6.V21
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
