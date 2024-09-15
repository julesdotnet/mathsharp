using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mathsharp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        { 

            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Form1 calcForm = new Form1();
            calcForm.Text = "Mathsharp v0.1";
            Application.Run(calcForm);
        }
    }
}
