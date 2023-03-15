using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrinkWaterAppRoutine
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            DrinkWaterAppRoutine form = new DrinkWaterAppRoutine();
            Application.EnableVisualStyles();
            form.WindowState = FormWindowState.Minimized;
            form.ShowInTaskbar = false; // Define o formulário para não ser exibido na barra de tarefas
            form.Visible = false;
            Application.Run(form);
        }
    }
}
