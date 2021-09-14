using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine();
            
            // catch command line args
            string[] arguments = Environment.GetCommandLineArgs();
            if (arguments.Length == 2 && arguments[1] == "--set-wall") {
                // set wallpaper according settings
                Form1 appForm = new Form1();
                appForm.setRandomWallpaper();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
