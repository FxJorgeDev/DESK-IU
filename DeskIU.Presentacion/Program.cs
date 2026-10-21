using System;
using System.Windows.Forms;
using DeskIU.Presentacion.Forms;

namespace DeskIU.Presentacion
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMenu());
        }
    }
}
